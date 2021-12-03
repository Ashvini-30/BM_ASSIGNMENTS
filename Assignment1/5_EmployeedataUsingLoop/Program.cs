using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeArray
{
    class Employee
    {
        int empid;
        string ename;
        string designation;
        int salary;

        public Employee()
        {
            Console.WriteLine("Enter emp no");
            empid = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter emp name");
            ename = Console.ReadLine();

            Console.WriteLine("Enter emp desg");
            designation = Console.ReadLine();

            Console.WriteLine("Enter emp salary");
            salary = Convert.ToInt32(Console.ReadLine());
        }

        public static void Main(string[] args)
        {
            Employee[] emp = new Employee[2];
            for (int i = 0; i < emp.Length; i++)
            {
                emp[i] = new Employee();
            }

            foreach (Employee e in emp)
            {
                Console.WriteLine("EmpNo:" + e.empid + " EmpName:" + e.ename + " Desg:" + e.designation + " Salary:Rs." + e.salary);
            }
        }

    }
}
