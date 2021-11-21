using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b,res;
            try
            {
                Console.WriteLine("Enter the two numbers");
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                res = a / b;
                Console.WriteLine("the division of two no is" + res);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);

            }
            catch(FormatException fe)
            {
                    Console.WriteLine(fe.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
            
        }
    }
}
