import { Component, OnInit,Input,Output,EventEmitter } from '@angular/core';
//import { EventEmitter } from 'stream';

@Component({
  selector: 'app-my-child',
  templateUrl: './my-child.component.html',
  styleUrls: ['./my-child.component.css']
})
export class MyChildComponent implements OnInit {
  @Input() count:number=0;
  num=10;

  @Output() valueChanged:EventEmitter<number>=new EventEmitter();

  constructor() { }

  ngOnInit(): void {
  }
  calculate()
  {
    this.num=this.num*10;
    this.valueChanged.emit(this.num);
  }

}
