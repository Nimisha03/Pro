import { Component, OnInit } from '@angular/core';
import { freeApiService } from '../services/freeapi.service';
import {Outlet} from '../outlet';
@Component({
  selector: 'app-editoutlet',
  templateUrl: './editoutlet.component.html',
  styleUrls: ['./editoutlet.component.css']
})
export class EditoutletComponent implements OnInit {
  id:number;
  outlets=new Outlet();
  constructor(private _freeApiService:freeApiService) { }

  ngOnInit(): void {
  }
   editoutletdetails(form)
   {
     this.id=form.id;
     this.outlets.outletName=form.outletname;
     this.outlets.streetName=form.streetname;
     this.outlets.landmark=form.lmark;
     this.outlets.noOfPackets=form.packet;
     this.outlets.noOfVolunteers=form.volunteer;
     this.outlets.foodType=form.food;
     this.outlets.date=form.date;
     console.log(this.outlets);
     this._freeApiService.editoutlets(this.id,this.outlets).subscribe(data=>{
       console.log(data);
       if(data)
       {
         alert('Outlet edited successfully!');
       }
       if(!data)
       {
         alert('Outlet not edited!');
       }
     });
   }
}
