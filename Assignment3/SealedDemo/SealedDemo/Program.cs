using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedDemo
{
    internal class Program
    {
        class parent             //we cannot inherit sealed class
        {
          /*  public sealed virtual void Demo()          //we cannot overide sealed method
            {
                Console.WriteLine("Parent demo");
            }*/
            public  virtual void Demo()          //we cannot overide sealed method
            {
                Console.WriteLine("Parent demo");
            }
        }
        class child:parent
        {
            public override void Demo()
            {
                Console.WriteLine("Child class");
            }
        }
        class Grandchild : child
        {
            public override void Demo()
            {
                Console.WriteLine("Grandchild class");
            }
        }

        static void Main(string[] args)
        {
            parent p=new parent();
            p.Demo();
            child c=new child();
            c.Demo();
            Console.ReadKey();
           

        }
    }
}
