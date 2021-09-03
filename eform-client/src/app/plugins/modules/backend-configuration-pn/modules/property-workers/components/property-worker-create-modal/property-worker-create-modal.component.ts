import {Component, EventEmitter, OnInit, Output, ViewChild} from '@angular/core';
import { DeviceUserModel } from 'src/app/common/models/device-users';
import {DeviceUserService} from 'src/app/common/services/device-users';
import {applicationLanguages} from 'src/app/common/const/application-languages.const';

@Component({
  selector: 'app-property-worker-modal',
  templateUrl: './property-worker-create-modal.component.html',
  styleUrls: ['./property-worker-create-modal.component.scss']
})
export class PropertyWorkerCreateModalComponent implements OnInit {
  @Output() onDeviceUserCreated: EventEmitter<void> = new EventEmitter<void>();
  @ViewChild('frame', { static: true }) frame;
  simpleSiteModel: DeviceUserModel = new DeviceUserModel();
  languages: any;
  constructor(private deviceUserService: DeviceUserService) { }

  ngOnInit() {
    this.languages = applicationLanguages;
  }

  show() {
    this.simpleSiteModel.languageCode = this.languages[1].locale;
    this.frame.show();
  }

  createDeviceUser() {
    this.deviceUserService.createSingleDeviceUser(this.simpleSiteModel).subscribe(operation => {
      if (operation && operation.success) {
        this.onDeviceUserCreated.emit();
        this.simpleSiteModel = new DeviceUserModel;
        this.frame.hide();
      }
    });
  }
}
