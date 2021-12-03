using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMethodSwapPrg
{
    class Program
    {
        public static void swap<T>(ref T a, ref T b)
        {
            T temp;
            temp = a;
            a = b;
            b = temp;
        }

        static void Main(string[] args)
        {
            int a = 30, b = 40;
            char ch1 = 'x', ch2 = 'y';

            Console.WriteLine("Before Swap the values are as follows");
            Console.WriteLine("a= " + a + " b=" + b);
            Console.WriteLine("ch1= " + ch1 + "  ch2=" + ch2);
            swap(ref a, ref b);
            swap(ref ch1, ref ch2);

           
            Console.WriteLine("after Swap the values are as follows");
            Console.WriteLine("a= " + a + " b=" + a);
            Console.WriteLine("ch1= " + ch1 + "  ch2=" + ch2);
            Console.ReadKey();

        }
       
    }
}
