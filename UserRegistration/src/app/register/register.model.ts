import {NgForm,
    FormGroup,
        FormControl,
                Validators,
    FormBuilder } from '@angular/forms'
// Create :- We create the validation object model
// Connect :- We connect the validation to the UI
// Check :- IsValid , IsDirty
export class Register{
    FirstName:string = "";
    LastName:string = "";
    Email:string = "";
    Phone:string ="";

    formRegisterGroup: FormGroup = null; // Create object of FormGroup
    constructor(){
        
        var _builder = new FormBuilder();
        this.formRegisterGroup = _builder.group({}); // Use the builder to create 
        // control --> validation
        // 1 control --> 1 validation
        this.formRegisterGroup.
        addControl("FirstName",
                    new FormControl('',Validators.required)
        );
        // Customer code control --> 
        //  Required , 4 letter numeric
       var validationcollection = [];
       validationcollection.push(Validators.required);
       

       this.formRegisterGroup.
       addControl("LastName",
                   new FormControl('',Validators.compose(validationcollection))
       );
    }

}