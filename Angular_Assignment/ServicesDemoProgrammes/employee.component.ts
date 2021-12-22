import { Component, OnInit } from '@angular/core';
import { IEmp, ServeEmployeeService } from '../serve-employee.service';

@Component({
  selector: 'app-employee',
  templateUrl: './employee.component.html',
  styleUrls: ['./employee.component.css']
})
export class EmployeeComponent implements OnInit {
empInfo:IEmp[]=[];
  constructor(public _getemployee:ServeEmployeeService) { 

  }

  ngOnInit(): void {
    this.empInfo=this._getemployee.getEmployee();
    console.log(this.empInfo);
  }

}
