import { Component, OnInit } from '@angular/core';
import {Admin} from '../admin';
import{Outlet} from '../outlet';
import {freeApiService} from '../services/freeapi.service';

@Component({
  selector: 'app-addoutlet',
  templateUrl: './addoutlet.component.html',
  styleUrls: ['./addoutlet.component.css']
})
export class AddoutletComponent implements OnInit {

  //admin=new Admin();
  admin:Admin;
  outlet=new Outlet();
  e:{};
  constructor(public _freeapiservice:freeApiService) { }

  ngOnInit(): void {
  }

   outletadd(e)
   {
     console.log(e);
    this.outlet.outletName=e.oname;
    this.outlet.streetName=e.sname;
    this.outlet.landmark=e.lmark;
    this.outlet.noOfPackets=e.packets;
    this.outlet.noOfVolunteers=e.vol;
    this.outlet.foodType=e.type;
    this.outlet.date=e.dates;
    console.log(this.outlet);
    this._freeapiservice.addoutlets(this.outlet).subscribe(data=>{
    console.log(data);
    if(data)
      {
        alert('Outlet added successfully!');
      }
     if(!data)
      {
        alert('Outlet not added.Outlet name exists!');
      }
    });

   }
}
