using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee1
{
   class Employee
    {
        int empno;
        string name, des;
        int sal;
        public int EMPNO
        {
            set { empno = value; }
            get { return empno; }
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public string Des
        {
            set { des = value; }
            get { return des; }

        }
        public int Sal
        {
            set { sal = value; }
            get { return sal; }
        }

    }
    class Programme
    {
        static void main(string args[])
        {
            Employee emp = new Employee();
            emp.EMPNO = 1;
            emp.Name = "Ashvini";
            emp.Des = "SDE";
            emp.Sal = 20000;
            Console.WriteLine("{0}-{1}-{2}-{3}", emp.EMPNO, emp.Name, emp.Des, emp.Sal);
            Console.ReadKey();
        }
    }
}
