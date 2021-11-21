using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphicClassWork
{
    abstract class Shape
    {
        public abstract void calculateArea();
    }
    class Circle : Shape
    {
        double r;
        public Circle(double n)
        {
            r = n;
        }
        public override void calculateArea()
        {
            double area;
            area = 3.14 * r * r;
            Console.WriteLine("the area of circle is" + area);
        }
    }
    class Rectangle : Shape
    {
        int l, b;
        public Rectangle(int length,int breadth)
        {
            l = length;
            b = breadth;
        }
        public override void calculateArea()
        {
            double area;
            area = l * b;
            Console.WriteLine("the area of rectangle is" + area);
           
        }

    }
    internal class Program
    {
        public  void call_Calculate_Area(Shape s)
        {
            s.calculateArea();


        }
        static void Main(string[] args)
        {
            Program p=new Program();
            Circle c = new Circle(4.5);
            Rectangle r = new Rectangle(3,4);
            p.call_Calculate_Area(c);
            p.call_Calculate_Area(r);
            Console.ReadKey();

        }
    }
}
