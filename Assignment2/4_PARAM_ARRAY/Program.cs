using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamArray
{
    class Program
    {



        public static int Average(params int[] no)
        {
            int sum = 0, avg = 0;
            for (int i = 0; i < no.Length; i++)
            {
                sum = sum + no[i];
            }

            avg = sum / no.Length;
            return avg;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("the average of given no is"+(Average(1, 2, 3)));
            Console.ReadKey();
        }
    }
}
