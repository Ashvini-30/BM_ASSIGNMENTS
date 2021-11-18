using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fib1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n,sum=0;
            int a = 0;
            int b = 1;
            Console.WriteLine("Enter the no up to which u want to print fib series");
            n = Convert.ToInt32(Console.ReadLine());
            while(sum<=n)
            {
                Console.Write(sum + " ");
                a = b;
                b = sum;
                sum = a + b;

            }
            Console.ReadKey()
;
            

        }
    }
}
