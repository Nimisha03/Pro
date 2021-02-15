import { Component, OnInit } from '@angular/core';
import {freeApiService} from '../services/freeapi.service';
import {Outlet} from '../outlet';

@Component({
  selector: 'app-outletdetails',
  templateUrl: './outletdetails.component.html',
  styleUrls: ['./outletdetails.component.css']
})
export class OutletdetailsComponent implements OnInit {
  outlets:Outlet[];
  constructor(private _freeapiservice:freeApiService) { }
  res:any;
  ngOnInit(): void {

    this._freeapiservice.getdetails().subscribe(data=>{
      
      this.outlets=data;
      console.log(this.outlets);
    });
  }
}
