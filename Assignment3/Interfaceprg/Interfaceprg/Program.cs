using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaceprg
{
    interface IPrintable
    {
        void print();
    }
    class Account:IPrintable
    {
        public void print()
        {
            Console.WriteLine("print account class method ");

        }
    }
    class Employee:IPrintable
    {
        public void print()
        {
            Console.WriteLine("print employee class method ");

        }

    }
    internal class Program
    {
        public void call_print(IPrintable ip)
        {
            ip.print();

        }
        static void Main(string[] args)
        {
          
            Account a=new Account();
            Employee e=new Employee();
            Program p = new Program();
            p.call_print(a);
            p.call_print(e);
            Console.ReadKey();
        }
    }
}
