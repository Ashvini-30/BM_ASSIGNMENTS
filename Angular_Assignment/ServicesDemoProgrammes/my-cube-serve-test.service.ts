import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class MyCubeServeTestService {
  //shareValue:String;

  constructor() { 
    //this.shareValue='MyService'+Math.round(Math.random()*100);
  }
  getValue(number1:any,number2:any,Operator:String)
  {
    //return this.shareValue;
    if(Operator=='+')
    return (number1+number2);
    else if(Operator=='-')
    return (number1-number2);
    else if(Operator=='*')
    return (number1*number2);
    else if(Operator=='/')
    return(number1/number2);
    
  }

  
}
