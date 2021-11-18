using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Employee e = new Employee();
            e.GetData();
            e.PrintData();
            Console.ReadKey();
         }
    }
    class Employee
    {
        int empno;
        string name;
        string designation;
        int sal;
        public void GetData()
        {
            Console.WriteLine("Enter no,name designation and salary of employee");
            empno=Convert.ToInt32(Console.ReadLine());
            name=Console.ReadLine();
            designation=Console.ReadLine();
            sal=Convert.ToInt32(Console.ReadLine());

        }
        public void PrintData()
        {
            Console.WriteLine("no- "+ empno +  "  name- " + name + "  designation- "+ designation + "  salary-" + sal);
        }
    }
}
