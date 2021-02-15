import { Component, OnInit } from '@angular/core';
import { Outlet } from '../outlet';
import { freeApiService } from '../services/freeapi.service';

@Component({
  selector: 'app-outletsearch',
  templateUrl: './outletsearch.component.html',
  styleUrls: ['./outletsearch.component.css']
})
export class OutletsearchComponent implements OnInit {
   outlets=new Outlet();
   id:number;
  constructor(private _freeapiservice:freeApiService) { }

  ngOnInit(): void {

  }
    outletsearch(form)
    {
    this.id=form.id;
    this._freeapiservice.searchoutlet(this.id).subscribe(data=>{
      console.log(data);
      this.outlets=data;
      console.log(this.outlets);
    });


  }

}
