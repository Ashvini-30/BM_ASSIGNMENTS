import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-reactive-form-group',
  templateUrl: './reactive-form-group.component.html',
  styleUrls: ['./reactive-form-group.component.css']
})
export class ReactiveFormGroupComponent implements OnInit {
 userForm:FormGroup;
  constructor() { 
    this.userForm=new FormGroup({
      name:new FormControl(''),
      pass:new FormControl(''),
      contactDetails:new FormGroup({
        landline:new FormControl(''),
        mobile:new FormControl('')
      }),

    });
  
    
  
  }
  

  ngOnInit(): void {
  }
  onSubmit()
    {
      console.log(this.userForm.value)
    }

}
