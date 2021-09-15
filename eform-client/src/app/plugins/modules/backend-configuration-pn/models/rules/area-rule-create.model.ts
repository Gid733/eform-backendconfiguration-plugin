import { CommonTranslationModel } from 'src/app/common/models';
import { AreaRuleT2Model } from './area-rule-t2.model';
import { AreaRuleT3Model } from './area-rule-t3.model';
import { AreaRuleT1Model } from './area-rule-t1.model';

export class AreaRulesCreateModel {
  areaRules: AreaRuleCreateModel[] = [];
}

export class AreaRuleCreateModel {
  translatedNames: CommonTranslationModel[] = [];
  typeSpecificFields: AreaRuleT1Model | AreaRuleT2Model | AreaRuleT3Model;
}
