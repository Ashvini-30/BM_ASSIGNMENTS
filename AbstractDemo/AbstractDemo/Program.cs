using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo
{
    abstract class shape
    {
        public abstract void CalculateArea();
    }
    class circle : shape
    {
        double r;
        public circle(int radius)
        {
            r = radius;
        }
        public override void CalculateArea()
        {
           
            double area = 3.14 * r * r;
            Console.WriteLine("the area of circle is " +area);
        }

    }
    class square:shape
    {
        int side;
        public square(int n)
        {
            side = n;
        }
        public override void CalculateArea()
        {
            int area = side * side;
            Console.WriteLine("the area of square" +area);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            circle c = new circle(5);
            c.CalculateArea();
            square s = new square(6);
            s.CalculateArea();
            Console.ReadKey();

        }
    }
}
