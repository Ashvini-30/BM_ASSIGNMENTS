import { Component, OnInit } from '@angular/core';
import { FormBuilder } from '@angular/forms';

@Component({
  selector: 'app-reactive-form',
  templateUrl: './reactive-form.component.html',
  styleUrls: ['./reactive-form.component.css']
})
export class ReactiveFormComponent implements OnInit {

  constructor(public fb:FormBuilder) { }
  AdmissionForm=this.fb.group({
    fullname:[''],
    email:[''],
    password:[''],
    mobile:[''],
    country:['']
  })
  country=['India','UK','Itali','Japan'];

  ngOnInit(): void {
  }
  onSubmit()
  {
    console.log(this.AdmissionForm.value);
  }

}
