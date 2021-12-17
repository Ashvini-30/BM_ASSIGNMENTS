import { ValueConverter } from '@angular/compiler/src/render3/view/template';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-bank',
  templateUrl: './bank.component.html',
  styleUrls: ['./bank.component.css']
})
export class BankComponent implements OnInit {
  balance:number=1000;

  constructor() { }

  ngOnInit(): void {
  }
  showBalance()
  {
    console.log(this.balance);
  }
  withdraw(value:number)
  {
    this.balance=this.balance-value;
    console.log(this.balance);
  }
  deposite(value:number)
  {
    this.balance=this.balance+value;
    console.log(this.balance);
  }

}
