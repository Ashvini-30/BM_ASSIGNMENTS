import { Component, OnInit } from '@angular/core';
import { FormBuilder,Validators } from '@angular/forms';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  constructor(public fb:FormBuilder) { }
  loginForm=this.fb.group({
    Uname:['',Validators.required,Validators.minLength(4)],
    email:['',Validators.required,Validators.pattern("[a-zA-Z0-9]+@[a-z]+[.][a-z]+")],
    Password:['', Validators.required]


  })

  ngOnInit(): void {

  }
  onSubmit()
  {
    console.log(this.loginForm.value);
  }

}
