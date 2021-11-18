using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEmployee
{
   class MainClass
    {
        static void main(string args[])
        {
            Employee e = new Employee();
            e.GetData();
            e.Display();
            Console.ReadKey();

        }
    }
    class Employee
    {
        int empno;
        string ename;
        string designation;
        int sal;
        public void GetData()
        {
            Console.WriteLine("Enter the empno,employee name, employee designation and salary");
            empno = Convert.ToInt32(Console.ReadLine());
            ename = Console.ReadLine();
            designation = Console.ReadLine();
            sal = Convert.ToInt32(Console.ReadLine());
        }
        public void Display()
        {
            Console.WriteLine("empno" +empno+ "Name" +ename+ "designation" +designation+ "salary" +sal);
            
                
        }
        
    }
}
