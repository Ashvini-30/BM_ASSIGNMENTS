import { Component, OnInit } from '@angular/core';
import { MyCubeServeTestService } from '../CubeServeDemoComponent/my-cube-serve-test.service';

@Component({
  selector: 'app-cube-serve-demo',
  templateUrl: './cube-serve-demo.component.html',
  styleUrls: ['./cube-serve-demo.component.css'],
  providers: [MyCubeServeTestService]
})
export class CubeServeDemoComponent implements OnInit {
  number1:number=0;
  number2:number=0;
  Operator:String="";
  MyService;
  MyRandomValue:any;
  constructor() { 
    this.MyService=new MyCubeServeTestService();
  }
  MyServiceValue()
  {
    this.MyRandomValue=this.MyService.getValue(this.number1,this.number2,this.Operator);
    console.log(this.MyRandomValue);
  }
  ngOnInit(): void {
  }

}
