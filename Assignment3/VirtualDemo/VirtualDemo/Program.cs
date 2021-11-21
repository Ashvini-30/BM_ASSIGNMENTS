using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualDemo
{
    internal class Program
    {
        class Parent
        {
            protected internal int a = 10;
            virtual public void print()
            {
                Console.WriteLine("parent class behaviours");
            }
        }
        class child : Parent
        {
            public override void print()
            {
                Console.WriteLine("Child class behaviours");
            }
        }
        static void Main(string[] args)
        {
            Parent p=new Parent();
            p.print();
            child c=new child();
            c.print();
            Console.ReadKey();
        }
    }
}
