import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-my-parent',
  templateUrl: './my-parent.component.html',
  styleUrls: ['./my-parent.component.css']
})
export class MyParentComponent implements OnInit {
  counter:number=4;
  Mynumber:number=0;

  constructor() { }

  ngOnInit(): void {
  }
  increment()
  {
    this.counter++;
  }
  decrement()
  {
    this.counter--;
  }
  Shownumber(num:any)
  {
    this.Mynumber=num;
    console.log(this.Mynumber);
  }

}
