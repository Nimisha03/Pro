import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import {FormsModule} from '@angular/forms';

import {freeApiService} from './services/freeapi.service';
import {HttpClient, HttpClientModule} from '@angular/common/http';
import { AppComponent } from './app.component';
import {LoginComponent} from './login/login.component';
import { AddoutletComponent } from './addoutlet/addoutlet.component';
import { AppRoutingModule } from './app-routing.module';
import { DeleteoutletComponent } from './deleteoutlet/deleteoutlet.component';
import { EditoutletComponent } from './editoutlet/editoutlet.component';
import { HomeComponent } from './home/home.component';
import { OutletdetailsComponent } from './outletdetails/outletdetails.component';
import { OutletsearchComponent } from './outletsearch/outletsearch.component';
import { RouterModule } from '@angular/router';



@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    AddoutletComponent,
    DeleteoutletComponent,
    EditoutletComponent,
    HomeComponent,
    OutletdetailsComponent,
    OutletsearchComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    AppRoutingModule,
    HttpClientModule,
   
  
  ],
  providers: [freeApiService],
  entryComponents: [AppComponent],
  bootstrap: [AppComponent]
})
export class AppModule { }
