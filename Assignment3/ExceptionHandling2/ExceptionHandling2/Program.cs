using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling2
{
    internal class Program
    {
        public void Divide()
        {
            int a, b, res;
            Console.WriteLine("enter two no");
            try
            {
                a=Convert.ToInt32(Console.ReadLine());
                b=Convert.ToInt32(Console.ReadLine());
                res = a / b;
                Console.WriteLine("the division of two no is " + res);

            }
            catch(FormatException f)
            {
                Console.WriteLine("exception has occured" +f.Message);
                throw f;
            }
            catch(OverflowException f)
            {
                Console.WriteLine("exception has occured " +f.Message);
                throw f;
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("exception has occured " + ex.Message);
                throw ex;
            }
            catch(ArithmeticException ae)
            {
                Console.WriteLine("exception has occured " + ae.Message);
                throw ae;

            }
            finally
            {
                Console.WriteLine("programme has executed ");
            }

        }
        static void Main(string[] args)
        {
            Program p=new Program();
            try
            {
                p.Divide();
            }
            catch(Exception exp)
            {
                p.Divide();
                Console.WriteLine(exp.Message);
            }
            Console.ReadLine();
        }
    }
}
