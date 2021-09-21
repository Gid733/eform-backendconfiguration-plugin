import {
  Component,
  EventEmitter,
  OnInit,
  Output,
  ViewChild,
} from '@angular/core';
import { PropertyAreaPlanningStatusesEnum } from '../../../enums';
import {
  PropertyAreaModel,
  PropertyAreasUpdateModel,
  PropertyModel,
  PropertyUpdateModel,
} from '../../../models';

@Component({
  selector: 'app-property-areas-view-modal',
  templateUrl: './property-areas-view-modal.component.html',
  styleUrls: ['./property-areas-view-modal.component.scss'],
})
export class PropertyAreasViewModalComponent implements OnInit {
  @ViewChild('frame', { static: false }) frame;
  selectedProperty: PropertyUpdateModel = new PropertyUpdateModel();
  selectedPropertyAreas: PropertyAreaModel[] = [];

  get areaPlanningStatuses() {
    return PropertyAreaPlanningStatusesEnum;
  }

  constructor() {}

  ngOnInit() {}

  show(model: PropertyModel, propertyAreas: PropertyAreaModel[]) {
    this.selectedProperty = { ...model, languagesIds: [] };
    this.selectedPropertyAreas = [...propertyAreas];
    this.frame.show();
  }

  hide() {
    this.selectedProperty = new PropertyUpdateModel();
    this.frame.hide();
  }
}
