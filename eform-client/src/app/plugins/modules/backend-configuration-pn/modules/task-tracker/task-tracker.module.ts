import {CommonModule} from '@angular/common';
import {NgModule} from '@angular/core';
import {RouterModule} from '@angular/router';
import {
  OwlDateTimeModule,
  OwlMomentDateTimeModule,
  OWL_DATE_TIME_FORMATS,
} from '@danielmoncada/angular-datetime-picker';
import {TranslateModule} from '@ngx-translate/core';
import {
  TaskTrackerContainerComponent,
  TaskTrackerTableComponent,
  TaskTrackerFiltersComponent,
  TaskTrackerCreateShowModalComponent,
} from './components';
import {TaskTrackerRouting} from './task-tracker.routing';
import {MY_MOMENT_FORMATS_FOR_TASK_MANAGEMENT} from '../../consts';
import {EformSharedModule} from 'src/app/common/modules/eform-shared/eform-shared.module';
import {FormsModule, ReactiveFormsModule} from '@angular/forms';
import {EformImportedModule} from 'src/app/common/modules/eform-imported/eform-imported.module';
import {MatButtonModule} from '@angular/material/button';
import {MatTooltipModule} from '@angular/material/tooltip';
import {MatIconModule} from '@angular/material/icon';
import {MatFormFieldModule} from '@angular/material/form-field';
import {MtxSelectModule} from '@ng-matero/extensions/select';
import {MatInputModule} from '@angular/material/input';
import {MtxGridModule} from '@ng-matero/extensions/grid';
import {MatDialogModule} from '@angular/material/dialog';
import {MatCardModule} from '@angular/material/card';

@NgModule({
  declarations: [
    TaskTrackerContainerComponent,
    TaskTrackerTableComponent,
    TaskTrackerFiltersComponent,
    TaskTrackerCreateShowModalComponent
  ],
  imports: [
    CommonModule,
    TranslateModule,
    RouterModule,
    OwlDateTimeModule,
    TaskTrackerRouting,
    OwlDateTimeModule,
    OwlMomentDateTimeModule,
    EformSharedModule,
    ReactiveFormsModule,
    EformImportedModule,
    FormsModule,
    MatButtonModule,
    MatTooltipModule,
    MatIconModule,
    MatFormFieldModule,
    MtxSelectModule,
    MatInputModule,
    MtxGridModule,
    MatDialogModule,
    MatCardModule,
  ],
  providers: [
    {
      provide: OWL_DATE_TIME_FORMATS,
      useValue: MY_MOMENT_FORMATS_FOR_TASK_MANAGEMENT,
    },
  ],
})
export class TaskTrackerModule {}