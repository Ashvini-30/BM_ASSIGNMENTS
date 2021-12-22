import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ServeEmployeeService {
  employee:IEmp[]=[];

  constructor() { }
  getEmployee()
  {
    this.employee=[
      
      {id:101,name:'ASH',gender:'female',salary:30000},
      {id:102,name:'ASH',gender:'female',salary:30000},
      {id:103,name:'ASH',gender:'female',salary:30000},
      {id:104,name:'ASH',gender:'female',salary:30000},
      {id:105,name:'ASH',gender:'female',salary:30000},

      

    ]
    return this.employee;
  }
  
}
export interface IEmp

  {
    id:number;
    name:string;
    gender:string;
    salary:number;

  }
