using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDemo
{
    internal class Program
    {
        public enum Days { sun,mon,tues=5,wed,thurs,fri,sat };
        static void Main(string[] args)
        {
           /* int firstday = (int)Days.mon;
            Console.WriteLine(firstday);
            int midday = (int)Days.wed;
            Console.WriteLine(midday);*/
           Program p=new Program();
            p.PrintDay(Days.mon);
            p.PrintDay(Days.thurs);

          

            Console.ReadKey();
           
        }
        public void PrintDay(Days d)
        {
            Console.WriteLine(d);
        }
    }
}
