using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                int[] a = new int[6];
                Console.WriteLine("enter the no");
                for(int i=0;i<10;i++)
                {
                    //Console.Write(i);
                    a[i]=Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("the array elements are");
                for(int i=0;i<6;i++)
                {
                    Console.Write(a[i]);
                }
            }
            catch(IndexOutOfRangeException e )
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();

        }
    }
}
