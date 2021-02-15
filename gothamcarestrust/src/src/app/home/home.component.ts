import { Component, OnInit } from '@angular/core';
import { title } from 'process';
import {LoginComponent} from '../login/login.component';
@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  title='Admin';
  
  constructor() { }

  ngOnInit(): void {
 
  
  }
  
}
