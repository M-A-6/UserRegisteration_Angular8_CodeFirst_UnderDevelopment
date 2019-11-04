import { Component, OnInit } from '@angular/core';
import { Register } from './register.model';
import { ReactiveFormsModule, FormGroup, FormControl, NgForm } from '@angular/forms';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  //registerModel : Register = new Register();
 // registerModels :Array<Register> = new Array<Register>();

  constructor() { }

 ngOnInit() {
    
  }

  RegisterUser(registerForm: NgForm): void {
    console.log(registerForm.value);
  }
}
