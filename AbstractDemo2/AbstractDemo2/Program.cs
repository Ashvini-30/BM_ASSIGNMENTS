using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo2
{
    abstract class Animal
    {
        public abstract void foodhabit();


    }
    class Herbivoures : Animal
    {
        public override void foodhabit()
        {
            Console.WriteLine("we are herbivoures animal");
        }
    }
    class Carnivoures : Animal
    {
        public override void foodhabit()
        {
            Console.WriteLine("We are Carnivoures animals");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Herbivoures h=new Herbivoures();
            h.foodhabit();
            Carnivoures c = new Carnivoures();
            c.foodhabit();
            Console.ReadKey();
        }
    }
}
