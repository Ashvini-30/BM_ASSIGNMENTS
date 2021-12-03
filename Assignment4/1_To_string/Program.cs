using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorCalling
{
    internal class Program
    {
        class Employee
        {
            int empno;
            string name, designation;
            public Employee(int eno,string ename,string des)
            {
                empno = eno;
                name = ename;
                    designation = des;
            }
            public Employee(int eno,string ename):this( eno, ename,"not assigned")
            {

            }
            public override string ToString()
            {
                return "empno " + empno + " empname " + name + " designation " + designation;
            }
            public override bool Equals(object obj)
            {
                Employee e = null;
                if (obj.GetType() == typeof(Employee))
                {
                    e = (Employee)obj;
                }
                else
                {
                    Console.WriteLine("passed object is not type of employee");
                    return false;
                }
                if(this.empno==e.empno && this.name==e.name && this.designation==e.designation)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }


        }
        static void Main(string[] args)
        {
            Employee e = new Employee(1,"ash");
            Employee e2 = new Employee(1, "ash");
            //Console.WriteLine(e);
            //Console.WriteLine(e2);
           // Console.WriteLine(e.GetType());
            //Console.WriteLine(e2.GetType());
            //Console.WriteLine(e.GetHashCode());
            //Console.WriteLine(e2.GetHashCode());
            if(e.Equals("e2"))
            {
                Console.WriteLine("objects are same");
            }
            else
            {
                Console.WriteLine("objects are different");

            }


            Console.ReadKey();

        }
    }
}
