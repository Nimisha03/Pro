import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AddoutletComponent } from './addoutlet/addoutlet.component';
import {LoginComponent} from './login/login.component';
import{Routes,RouterModule}from '@angular/router';
import { DeleteoutletComponent } from './deleteoutlet/deleteoutlet.component';
import { EditoutletComponent } from './editoutlet/editoutlet.component';
import {OutletsearchComponent} from './outletsearch/outletsearch.component';
import { HomeComponent } from './home/home.component';
import { OutletdetailsComponent } from './outletdetails/outletdetails.component';

const approutes:Routes=[
  {
    path:'',redirectTo: 'login',
    pathMatch: "full"
  },
  {
   path:'login',component:LoginComponent,
  
  },
  {
    path:'search',component:OutletsearchComponent
  },
  {
      path:'admin',component:HomeComponent
  },
  {
      path:'outletdetails',component:OutletdetailsComponent
  },
  {
      path:'add',component: AddoutletComponent
  },
  {
      path:'delete', component:DeleteoutletComponent
  },
  {
    path:'edit', component:EditoutletComponent
}
  
  ];


@NgModule({
  
  imports: [
    
    RouterModule.forRoot(approutes),
    CommonModule
  ],
  exports:[RouterModule]
})
export class AppRoutingModule { }
