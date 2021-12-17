import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-calculator',
  templateUrl: './calculator.component.html',
  styleUrls: ['./calculator.component.css']
})
export class CalculatorComponent implements OnInit {
  num1:number=200;
  num2:number=100

  constructor() { }

  ngOnInit(): void {
  }
  Addition()
  {
    console.log(this.num1+this.num2);
  }
  Subtraction()
  {
    console.log(this.num1-this.num2);
  }
  multiplication()
  {
    console.log(this.num1*this.num2);
  }
  division()
  {
    console.log(this.num1/this.num2);
  }

}
