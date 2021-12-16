var Student = /** @class */ (function () {
    function Student(rollno, sname, p1, c1, m1) {
        this.roll_no = rollno;
        this.name = sname;
        this.phy_marks = p1;
        this.che_marks = c1;
        this.math_marks = m1;
    }
    Student.prototype.Calculate_Per = function () {
        this.percentage = (this.phy_marks + this.che_marks + this.math_marks) / 3;
        if (this.percentage > 80)
            console.log("A grade");
        else if (this.percentage > 60 && this.percentage < 80)
            console.log("B grade");
        else if (this.percentage > 35 && this.percentage < 60)
            console.log("C grade");
        else
            console.log("Fail");
    };
    Student.prototype.Display = function () {
        console.log("Roll No" + " " + "StuName" + " " + "Phy_marks" + " " + "che_marks" + " " + "math_marks" + "Percentage");
        console.log(this.roll_no + " " + this.name + " " + this.phy_marks + " " + this.che_marks + " " + this.math_marks + " " + this.percentage + " " + this.grade);
    };
    return Student;
}());
var s1 = new Student(1, "Ash", 70, 80, 90);
var s2 = new Student(2, "Aryan", 80, 50, 35);
var s3 = new Student(3, "Abhi", 80, 40, 60);
s1.Calculate_Per();
s1.Display();
s2.Calculate_Per();
s2.Display();
s3.Calculate_Per();
s3.Display();
