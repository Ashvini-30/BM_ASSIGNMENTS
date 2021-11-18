using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Enter your age");
            age = Convert.ToInt32(Console.ReadLine());
            if (age > 18)
                Console.WriteLine("You can drive a car");
            else if (age < 18)
                Console.WriteLine("Sorry,You can't drive a car");
        }
    }
}
