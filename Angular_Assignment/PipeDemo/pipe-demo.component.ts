import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-pipe-demo',
  templateUrl: './pipe-demo.component.html',
  styleUrls: ['./pipe-demo.component.css']
})
export class PipeDemoComponent implements OnInit {
  message:String;
 mydate:Date;

  constructor() {
    this.message="This is my string";
    this.mydate=new Date();
   
   }

  ngOnInit(): void {
  }

}
