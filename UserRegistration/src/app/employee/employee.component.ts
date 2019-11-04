import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'employee-root',
  templateUrl: './employee.component.html',
 // styleUrls: ['./employee.component.css']
})

export class EmployeeComponent 


//implements OnInit {
  
  // dtOptions: DataTables.Settings = {};
  // persons: any;
  // employees:any;

  // dtTrigger: Subject<any> = new Subject();
  // constructor(private employeeService: EmployeeService) {}

 //  ngOnInit(): void {
  //   this.dtOptions = {
  //     pagingType: 'full_numbers',
  //     pageLength: 2
  //  };
   
  //   this.employeeService.getallemployees().subscribe(persons => {
  //     this.persons = persons;

  //     this.dtTrigger.next();
  // });    
   
  //   }
  
//}


implements OnInit {
  page =true;
  constructor(private _router: Router) {
    if(sessionStorage.getItem("userName")==null)
      {
        this._router.navigate(['/login']);
      }
   }
  
  ngOnInit() {
   
  }

}