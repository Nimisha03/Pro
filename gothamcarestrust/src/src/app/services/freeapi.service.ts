import {Injectable} from '@angular/core';
import {Observable} from 'rxjs';
import{HttpClient, HttpClientModule,HttpParams} from '@angular/common/http';
import  {LoginComponent} from '../login/login.component';
import { allowedNodeEnvironmentFlags } from 'process';
import {Admin} from '../admin';
import {Outlet} from '../outlet';

@Injectable()
export class freeApiService
{   
   
constructor( private httpclient:HttpClient)
  {}
    getdetails():Observable<any>
    {
      return this.httpclient.get("https://localhost:44339/api/Outlet/get/outlets");
    }
    checkadmin(admin):Observable<any>{
    return this.httpclient.post("https://localhost:44339/api/Outlet/verify/admin",admin);
    }

    addoutlets(outlet):Observable<any>{
      return this.httpclient.post("https://localhost:44339/api/Outlet/add/outlet",outlet);
    }

    deleteoutlets(id:any):Observable<any>
    {
      
      return this.httpclient.delete("https://localhost:44339/api/Outlet/"+id);
    }
    editoutlets(id,outlets):Observable<any>{
      return this.httpclient.put("https://localhost:44339/api/Outlet/"+id,outlets);
    }
    searchoutlet(id:any):Observable<any>
    {
      return this.httpclient.get("https://localhost:44339/api/Outlet/"+id);
    }

    }

