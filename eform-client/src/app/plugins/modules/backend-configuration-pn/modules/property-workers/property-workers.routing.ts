import {NgModule} from '@angular/core';
import {RouterModule, Routes} from '@angular/router';
import {UserClaimsEnum} from 'src/app/common/const';
import {ClaimsGuard} from 'src/app/common/guards/claims.guard';
import {PropertyWorkersPageComponent} from './components';

const routes: Routes = [
  {
    path: '',
    component: PropertyWorkersPageComponent,
    canActivate: [ClaimsGuard],
    data: {requiredClaim: UserClaimsEnum.deviceUsersRead}
  }
];


@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class PropertyWorkersRouting {
}
