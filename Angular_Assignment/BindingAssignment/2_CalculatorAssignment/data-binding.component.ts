import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-data-binding',
  templateUrl: './data-binding.component.html',
  styleUrls: ['./data-binding.component.css']
})
export class DataBindingComponent implements OnInit {
  Myapp:String="Heyy,i am in Interpollation";
  isdisabled=false;
  

 
  constructor() { }

  ngOnInit(): void {
  }
  Display(): String{
    return "I am in Display method";
  }

}
