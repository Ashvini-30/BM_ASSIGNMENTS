using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePrg2
{
    interface IFlyer
    {
        void fly();
        void land();
    }
    class bird:IFlyer
    {
        public void fly()
        {
            Console.WriteLine("fly bird");
        }
        public void land()
        {
            Console.WriteLine("land bird");
        }
           
        
    }
    class plane:IFlyer
    {
        public void fly()
        {
            Console.WriteLine("fly plane");
        }
        public void land()
        {
            Console.WriteLine("land plane");
        }

    }

    internal class Program
    {
        public void call_flyer(IFlyer f)
        {
            f.fly();
            f.land();
        }
        static void Main(string[] args)
        {
            bird b = new bird();
            plane pl = new plane();
            Program p=new Program();
            p.call_flyer(b);
            p.call_flyer(pl);
            Console.ReadKey();

        }
    }
}
