import { Component, OnInit, Input } from '@angular/core';
import {NgForm,FormGroup,FormControl,Validator,FormBuilder, Validators} from '@angular/forms'
import { LoginService } from '../services/login.service';
import { Router } from '@angular/router';
@Component({
  selector: 'app-root',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})



export class LoginComponent implements OnInit {


  formLoginGroup: FormGroup;
  fb = new FormBuilder();

  constructor(private loginService: LoginService,private _router: Router) {
    this.formLoginGroup = this.fb.group({
      Email: ['', [Validators.required, Validators.minLength(2), Validators.maxLength(10)]],
      Password :  ['', [Validators.required, Validators.minLength(2), Validators.maxLength(10)]],
      RememberMe : false
      // OtherFields...
    });
  }

  ngOnInit() {
  }


  onSubmit(): void {
    console.log(this.formLoginGroup.value);  
    this.loginService.userLogin(this.formLoginGroup.value)
    .subscribe(res=>this.Success(res),
        res=>this.Error(res));
    }
    Error(res) {
        console.log(res);
      }
      Success(res) {
        console.log(res);
        sessionStorage.setItem("userName",this.formLoginGroup.value.Email);
        this._router.navigate(['/employees']);
      }
  

  Add()
  {
    //console.log(stringify(this.formLoginGroup.value));
    //console.log(this.formLoginGroup);
    //console.log(event.target.Email.value);
    //console.log(event.target.Password.value);
    //console.log('-------'+this.formLoginGroup.getRawValue());
    //console.log(this.formLoginGroup.value);
    console.log("Form clicked!");// , event); 
 
//    this.loginService.userLogin().subscribe(res=>this.Success(res),
//    res=>this.Error(res));
} 

 
// Error(res) {
//   console.debug(res);
// }
// Success(res) {
//   console.debug(res);
// }

  //hasError(typeofvalidator:string,controlname:string) //: boolean
  //{
 //return this.UserModel.formLoginGroup.contains[controlname].hasError(typeofvalidator);

  //}
  // LoginUser($event)
  // {
  //   console.log("Save button is clicked!" , $event); 
  // }

}

