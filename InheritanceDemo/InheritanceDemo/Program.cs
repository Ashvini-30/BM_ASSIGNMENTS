using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Employee
    {
        int id;
        string name;
        string desig;
        public Employee(int id,string name,string desig)
        {
            this.id = id;
            this.name = name;
            this.desig = desig;
        }
        public void PrintData()
        {
            Console.WriteLine(id + " " + name + " " + desig);
        }
    }
    class PermanantEmp : Employee
    {
        double basicsal;
        public PermanantEmp(int id, string name, string desig, double basicsal) : base(id, name, desig)
        {
              this.basicsal = basicsal;
        }
        public void PrintData()
        {
            base.PrintData();
            Console.WriteLine(basicsal);
        }
        public void CalculateSal(double basicsal)
        {
            double hra = 0.5 * basicsal;
            double da = 0.3 * basicsal;
            double gross_sal = basicsal + hra + da;
            Console.WriteLine(gross_sal + " is gross salary of permanant employee");
        }
        
     }
    class WagedEmp : Employee
    {
    int no_of_hrs;
    int hrs_amt;
    public WagedEmp(int id, string name, string desig, int no_of_hrs, int hrs_amt) : base(id, name, desig)
    {
           this.no_of_hrs =no_of_hrs;
         this.hrs_amt=hrs_amt;

     }
        public void PrintData()
        {
            base.PrintData();
            Console.WriteLine(no_of_hrs + " " + hrs_amt);
        }
        public void CalculateSal(int no_of_hrs,int hrs_amt)
        {
            int sal = no_of_hrs * hrs_amt;
            Console.WriteLine(sal + " is salary of waged employee");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

        PermanantEmp e1 = new PermanantEmp(101, "Ash", "Manager", 200000);
        WagedEmp e2 = new WagedEmp(102, "Arnav", "SDE", 10, 2000);
        Console.WriteLine("Permanant Employee");
            
            e1.PrintData();
            e1.CalculateSal(20000);

            Console.WriteLine("Waged Employee");
            e2.PrintData();
            e2.CalculateSal(10, 2000);

        Console.ReadKey();
        }
    }
}
