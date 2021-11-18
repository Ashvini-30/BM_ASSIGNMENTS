using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchPrg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int month;
            Console.WriteLine("Enter the month no ");
            month = Convert.ToInt32(Console.ReadLine());
            switch(month)
            {
                case 1:
                    Console.WriteLine("Month 1 has 31 days");
                    break;
                case 2:
                    Console.WriteLine("Month 2 has 28 days");
                    break;
                case 3:
                    Console.WriteLine("Month 3 has 31 days");
                    break;
                case 4:
                    Console.WriteLine("Month 4 has 30 days");
                    break;
                case 5:
                    Console.WriteLine("Month 5 has 31 days");
                    break;
                case 6:
                    Console.WriteLine("Month 1 has 30 days");
                    break;
                case 7:
                    Console.WriteLine("Month 7 has 31 days");
                    break;
                case 8:
                    Console.WriteLine("Month 8 has 31 days");
                    break;
                case 9:
                    Console.WriteLine("Month 9 has 30 days");
                    break;
                case 10:
                    Console.WriteLine("Month 10 has 31 days");
                    break;
                case 11:
                    Console.WriteLine("Month 11 has 30 days");
                    break;
                case 12:
                    Console.WriteLine("Month 12 has 31 days");
                    break;
                default:
                    Console.WriteLine("please enter valid no");
                    break;
            }
            Console.ReadKey();
        }
    }
}
