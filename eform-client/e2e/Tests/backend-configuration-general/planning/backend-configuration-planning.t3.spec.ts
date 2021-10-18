import loginPage from '../../../Page objects/Login.page';
import backendConfigurationPropertiesPage, {
  PropertyCreateUpdate,
} from '../../../Page objects/BackendConfiguration/BackendConfigurationProperties.page';
import { expect } from 'chai';
import { generateRandmString } from '../../../Helpers/helper-functions';
import backendConfigurationPropertyWorkersPage from '../../../Page objects/BackendConfiguration/BackendConfigurationPropertyWorkers.page';
import backendConfigurationAreaRulesPage, {
  AreaRuleCreateUpdate,
  AreaRulePlanningCreateUpdate,
} from '../../../Page objects/BackendConfiguration/BackendConfigurationAreaRules.page';
import { format, sub } from 'date-fns';
import itemsPlanningPlanningPage from '../../../Page objects/ItemsPlanning/ItemsPlanningPlanningPage';

const property: PropertyCreateUpdate = {
  name: generateRandmString(),
  chrNumber: generateRandmString(),
  address: generateRandmString(),
  selectedLanguages: [{ languageId: 1, languageName: 'Danish' }],
};
const workerForCreate = {
  name: generateRandmString(),
  surname: generateRandmString(),
  language: 'Danish',
  properties: [0],
};

describe('Backend Configuration Area Rules Planning Type3', function () {
  before(async () => {
    await loginPage.open('/auth');
    await loginPage.login();
    await backendConfigurationPropertiesPage.goToProperties();
    await backendConfigurationPropertiesPage.createProperty(property);
    await backendConfigurationPropertyWorkersPage.goToPropertyWorkers();
    await backendConfigurationPropertyWorkersPage.create(workerForCreate);
    await backendConfigurationPropertiesPage.goToProperties();
    const lastProperty = await backendConfigurationPropertiesPage.getLastPropertyRowObject();
    await lastProperty.editBindWithAreas([4]); // bind specific type3
    await lastProperty.openAreasViewModal(0); // go to area rule page
  });
  it('should create new planning from default area rule', async () => {
    const rowNum = await backendConfigurationAreaRulesPage.rowNum();
    expect(rowNum, 'have some non-default area rules').eq(0);
    const areaRuleForCreate: AreaRuleCreateUpdate = {
      name: generateRandmString(),
    };
    await backendConfigurationAreaRulesPage.createAreaRule(areaRuleForCreate);

    const areaRule = await backendConfigurationAreaRulesPage.getFirstAreaRuleRowObject();
    const areaRulePlanning: AreaRulePlanningCreateUpdate = {
    //   startDate: format(new Date(), 'yyyy/MM/dd'),
      workers: [{ workerNumber: 0 }],
    };
    await areaRule.createUpdatePlanning(areaRulePlanning);
    // areaRulePlanning.startDate = format(
    //   sub(new Date(), { days: 1 }),
    //   'yyyy/MM/dd'
    // ); // fix test
    const areaRulePlanningCreated = await areaRule.readPlanning();
    // expect(areaRulePlanningCreated.startDate).eq(areaRulePlanning.startDate);
    expect(areaRulePlanningCreated.workers[0].name).eq(
      `${workerForCreate.name} ${workerForCreate.surname}`
    );
    expect(areaRulePlanningCreated.workers[0].checked).eq(true);
    await itemsPlanningPlanningPage.goToPlanningsPage();
    expect(
      await itemsPlanningPlanningPage.rowNum(),
      'items planning not create or create not correct'
    ).eq(2);
    const itemPlannings = await itemsPlanningPlanningPage.getAllPlannings();
    // first planning
    expect(itemPlannings[0].eFormName).eq('05. Stald_klargøring');
    expect(itemPlannings[0].name).eq(areaRule.name);
    expect(itemPlannings[0].folderName).eq(`${property.name} - 05. Stalde`);
    expect(itemPlannings[0].repeatEvery).eq(1);
    expect(itemPlannings[0].repeatType).eq('Dag');
    let workers = await itemPlannings[0].readPairing();
    expect([
      {
        workerName: `${workerForCreate.name} ${workerForCreate.surname}`,
        workerValue: true,
      },
    ]).deep.eq(workers);
    // second planning
    expect(itemPlannings[1].eFormName).eq('24. Halebid_NEW');
    expect(itemPlannings[1].name).eq('Hale bid');
    expect(itemPlannings[1].folderName).eq(`${property.name} - 05. Stalde`);
    expect(itemPlannings[1].repeatEvery).eq(1);
    expect(itemPlannings[1].repeatType).eq('Dag');
    workers = await itemPlannings[1].readPairing();
    expect([
      {
        workerName: `${workerForCreate.name} ${workerForCreate.surname}`,
        workerValue: true,
      },
    ]).deep.eq(workers);

    browser.back();
    await areaRule.createUpdatePlanning({ status: false }); // delete item planning
    await areaRule.delete();
  });
  after(async () => {
    await backendConfigurationPropertiesPage.goToProperties();
    await backendConfigurationPropertiesPage.clearTable();
    await backendConfigurationPropertyWorkersPage.goToPropertyWorkers();
    await backendConfigurationPropertyWorkersPage.clearTable();
  });
});