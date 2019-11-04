import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})

export class HomeComponent implements OnInit {
  title = 'UserRegistration';
  page:boolean = false;
  initialCount:number =10;
  constructor() { }

  ngOnInit() {
  }
}
