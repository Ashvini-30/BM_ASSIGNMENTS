using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmatic_Operation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first no");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second no");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("the addition of two no is"+ (a + b));
            Console.WriteLine("the subtraction of two no is"+ (a -b));
            Console.WriteLine("the multiplication of two no is"+ (a * b));
            Console.WriteLine("the division of two no is" +(a / b));
            Console.WriteLine("the modules of two no is" + (a % b));

           /* int a, b;
            string op;
            Console.WriteLine("Enter the first no");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second  no");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the operation that you want to performed");
            op = Console.ReadLine();
            switch (op)
            {
                case '+':


                    Console.WriteLine("the addition of two no is", a + b);
                    break;
                case '-':

                    Console.WriteLine("the subtraction of two no is", a - b);
                    break;

                default:
                    Console.WriteLine("PLEASE ENTER VALID OPERATION");
                    break;

            }*/
           
           

            Console.ReadLine();


        }
    }
}
