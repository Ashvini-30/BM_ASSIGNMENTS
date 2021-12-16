var employee = /** @class */ (function () {
    function employee(eid, ename, dno, sal) {
        this.eid = eid;
        this.empname = ename;
        this.deptno = dno;
        this.salary = sal;
    }
    employee.prototype.Calculate_Gross_sal = function () {
        if (this.salary < 20000) {
            this.hra = 0.2;
            this.da = 0.8;
            this.gross_sal = this.salary + this.hra + this.da;
            console.log("the gross salary of employee" + this.gross_sal);
        }
        else if (this.salary > 20000 && this.salary < 35000) {
            this.hra = 0.25;
            this.da = 0.7;
            this.gross_sal = this.salary + this.hra + this.da;
            console.log("the gross salary of employee" + this.gross_sal);
        }
    };
    employee.prototype.Display = function () {
        console.log(this.eid + " " + this.empname + " " + this.deptno + " " + this.salary + " " + this.gross_sal);
    };
    return employee;
}());
var e1 = new employee(1, "ram", 5, 10000);
var e2 = new employee(2, "rani", 6, 30000);
var e3 = new employee(3, "akash", 2, 15000);
e1.Calculate_Gross_sal();
e1.Display();
e2.Calculate_Gross_sal();
e2.Display();
e3.Calculate_Gross_sal();
e3.Display();
