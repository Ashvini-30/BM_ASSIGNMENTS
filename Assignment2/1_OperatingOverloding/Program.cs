using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloding
{
    class Student
    {
        int marks;
        public Student(int m)
        {
            marks = m;
        }
        public static Student operator +(Student a, Student b)
        {
            Student res = new Student(0);
            res.marks = a.marks + b.marks;
            return res;

        }
        public static Student operator - (Student a,Student b)
            {
            Student res = new Student(0);
              res.marks = a.marks - b.marks;
            return res;

            }
        public static Student operator *(Student a,Student b)
        {
            Student res = new Student(1);
            res.marks = a.marks * b.marks;
            return res;
        }
        public static Student operator /(Student a,Student b)
        {
            Student res = new Student(1);
            res.marks = a.marks / b.marks;
            return res;
        }
        public static  bool operator ==(Student a,Student b)
        {
            if(a.marks==b.marks)
             return true;
             else
               return false;

            
        }
        public static bool operator !=(Student a, Student b)
        {
            if (a.marks != b.marks)
                return true;
            else
                return false;


        }
        public void printmarks()
        {
            Console.WriteLine(marks);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student obj1 = new Student(100);
            Student obj2 = new Student(50);
            Student addres = obj1 + obj2;
            addres.printmarks();
        Student subres = obj1 - obj2;
        subres.printmarks();
            Student mulres = obj1 * obj2;
            mulres.printmarks();
            Student divres = obj1 / obj2;
            divres.printmarks();
          if(obj1==obj2)
                Console.WriteLine("Marks are equal");
            else
                Console.WriteLine("Marks are not equal");
            Console.ReadKey();
        }
    }
}
