import { Component, OnDestroy, OnInit, ViewChild } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { AutoUnsubscribe } from 'ngx-auto-unsubscribe';
import { Subscription } from 'rxjs';
import { AuthStateService } from 'src/app/common/store';
import { AreaModel } from 'src/app/plugins/modules/backend-configuration-pn/models/area.model';
import { AreaRulePlanModalComponent } from '../../rule-plans';
import {
  AreaRuleCreateModalComponent,
  AreaRuleDeleteModalComponent,
  AreaRuleEditModalComponent,
} from '../';
import {
  AreaRulePlanningModel,
  AreaRulesCreateModel,
  AreaRuleSimpleModel,
  AreaRuleUpdateModel,
} from '../../../../../models';
import { BackendConfigurationPnAreasService } from '../../../../../services/backend-configuration-pn-areas.service';

@AutoUnsubscribe()
@Component({
  selector: 'app-area-rules-container',
  templateUrl: './area-rules-container.component.html',
  styleUrls: ['./area-rules-container.component.scss'],
})
export class AreaRulesContainerComponent implements OnInit, OnDestroy {
  areaRules: AreaRuleSimpleModel[] = [];
  @ViewChild('createAreaRuleModal', { static: false })
  createAreaRuleModal: AreaRuleCreateModalComponent;
  @ViewChild('editAreaRuleModal', { static: false })
  editAreaRuleModal: AreaRuleEditModalComponent;
  @ViewChild('deleteAreaRuleModal', { static: false })
  deleteAreaRuleModal: AreaRuleDeleteModalComponent;
  @ViewChild('planAreaRuleModal', { static: false })
  planAreaRuleModal: AreaRulePlanModalComponent;

  areaRulesModel: AreaRuleSimpleModel[] = [];
  selectedArea: AreaModel = new AreaModel();
  selectedAreaId: number;

  getAreaRulesSub$: Subscription;
  getAreaRulePlanningSub$: Subscription;
  getAreaSub$: Subscription;
  getSingleAreaRuleSub$: Subscription;
  createAreaRuleSub$: Subscription;
  editAreaRuleSub$: Subscription;
  deleteAreaRuleSub$: Subscription;
  planAreaRuleSub$: Subscription;

  constructor(
    private areasService: BackendConfigurationPnAreasService,
    public authStateService: AuthStateService,
    private route: ActivatedRoute
  ) {}

  ngOnInit() {
    this.route.params.subscribe((params) => {
      const selectedAreaId = params['areaId'];
      this.selectedAreaId = selectedAreaId;
      this.getAreaRules(selectedAreaId);
      this.getArea(selectedAreaId);
    });
  }

  getArea(areaId: number) {
    this.getAreaSub$ = this.areasService.getArea(areaId).subscribe((data) => {
      this.selectedArea = data.model;
    });
  }

  getAreaRules(areaId: number) {
    this.getAreaRulesSub$ = this.areasService
      .getAreaRules(areaId)
      .subscribe((data) => {
        this.areaRulesModel = data.model;
      });
  }

  showAreaRulePlanning(rule: AreaRuleSimpleModel) {
    this.getAreaRulePlanningSub$ = this.areasService
      .getAreaRulePlanning(rule.id)
      .subscribe((data) => {
        this.planAreaRuleModal.show(data.model);
      });
  }

  showEditAreaRule(rule: AreaRuleSimpleModel) {
    this.getSingleAreaRuleSub$ = this.areasService
      .getSingleAreaRule(rule.id)
      .subscribe((data) => {
        this.editAreaRuleModal.show(data.model);
      });
  }

  showAreaRuleCreateModal() {
    this.createAreaRuleModal.show();
  }

  showDeleteAreaRuleModal(rule: AreaRuleSimpleModel) {
    this.deleteAreaRuleModal.show(rule);
  }

  onCreateAreaRule(model: AreaRulesCreateModel) {
    this.createAreaRuleSub$ = this.areasService
      .createAreaRules(model)
      .subscribe((data) => {
        if (data && data.success) {
          this.getAreaRules(this.selectedAreaId);
          this.createAreaRuleModal.hide();
        }
      });
  }

  onUpdateAreaRule(model: AreaRuleUpdateModel) {
    this.editAreaRuleSub$ = this.areasService
      .updateAreaRule(model)
      .subscribe((data) => {
        if (data && data.success) {
          this.getAreaRules(this.selectedAreaId);
          this.editAreaRuleModal.hide();
        }
      });
  }

  onDeleteAreaRule(areaRuleId: number) {
    this.deleteAreaRuleSub$ = this.areasService
      .deleteAreaRule(areaRuleId)
      .subscribe((data) => {
        if (data && data.success) {
          this.getAreaRules(this.selectedAreaId);
          this.deleteAreaRuleModal.hide();
        }
      });
  }

  onUpdateAreaRulePlan(rulePlanning: AreaRulePlanningModel) {
    this.planAreaRuleSub$ = this.areasService
      .updateAreaRulePlanning(rulePlanning)
      .subscribe((data) => {
        if (data && data.success) {
          this.getAreaRules(this.selectedAreaId);
          this.planAreaRuleModal.hide();
        }
      });
  }

  ngOnDestroy(): void {}
}
