import { Component, OnInit} from '@angular/core';
import { freeApiService } from '../services/freeapi.service';
import {FormsModule} from '@angular/forms';
import {  Router} from '@angular/router';
import { AppComponent } from '../app.component';
import { Admin } from '../admin';


@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  admin=new Admin();
  title:string;
  e:object;
  constructor( private _freeApiService :freeApiService,
    public router:Router) {}
    

  ngOnInit(): void {  }
   loginUser(e)
   {
    console.log(e);
    this.admin.username=e.uname;
    this.admin.password=e.psswrd;
    this._freeApiService.checkadmin(this.admin).subscribe(data=>{
    
    if(data)
      { 
      console.log("Admin");
      this.title="Admin!";
      alert('Welcome Admin!');
      this.router.navigate(['/admin']);
      
      }
    if(!data)
      {
        console.log("Not Admin");
        alert('Welcome User!');
        this.router.navigate(['/outletdetails']);
      }
        
    });
    //console.log(this.admin);
    //console.log(this.valid);
    //if(this.valid)
     //{ 
      //this.router.navigate(['/admin']);
     // console.log("Admin");
     //}
    //else
     //{
      // console.log("Not Admin");
     //}
     
    }
  
}
 

