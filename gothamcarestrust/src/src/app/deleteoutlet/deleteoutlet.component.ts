import { Component, OnInit } from '@angular/core';
import { Outlet } from '../outlet';
import { freeApiService } from '../services/freeapi.service';

@Component({
  selector: 'app-deleteoutlet',
  templateUrl: './deleteoutlet.component.html',
  styleUrls: ['./deleteoutlet.component.css']
})
export class DeleteoutletComponent implements OnInit {
 outlets=new Outlet();
 id:number;
  constructor(private _freeApiService:freeApiService) { }

  ngOnInit(): void {
  }

  deleteoutlet(e){
    console.log(e);
    this.id=e.id;
   this._freeApiService.deleteoutlets(this.id).subscribe(data=>{
     if(data)
     {
       alert("Deleted!");
     }
     if(!data)
     {
        alert("Not deleted!");
     }
   });
  }

}
