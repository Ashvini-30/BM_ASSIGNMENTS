import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-form-demo',
  templateUrl: './form-demo.component.html',
  styleUrls: ['./form-demo.component.css']
})
export class FormDemoComponent implements OnInit {

  constructor() { }
  country=['India','UK','JAPAN','Dubai'];

  ngOnInit(): void {
  }
 onSubmit(value:any)
 {
   console.log(value);

 }
}
