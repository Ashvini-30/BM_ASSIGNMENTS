using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphicEx
{
    abstract class Account
    {
        public abstract void CalculateInterest();
    }
     class Saving : Account
    {
        int p;
        double r;
        int n;
        public Saving(int principle,double rate,int year)
        {
            p= principle;
            r=rate;
                n=year;
        }
        public override void CalculateInterest()
        {
            double si;
            si = (p * r * n) / 100;
            Console.WriteLine("the simple interest for saving account is " + si);
        }

    } 
    class Current : Account
    {
        int p;
        double r;
        int n;
        public Current(int principle, double rate, int year)
        {
            p = principle;
            r = rate;
            n = year;
        }
        public override void CalculateInterest()
        {
            double si;
            si = (p * r * n) / 100;
            Console.WriteLine("the simple interest for Current account is " + si);
        }

    }
    class FD : Account
    {
        int p;
        double r;
        int n;
        public FD(int principle, double rate, int year)
        {
            p = principle;
            r = rate;
            n = year;
        }
        public override void CalculateInterest()
        {
            double si;
            si = (p * r * n) / 100;
            Console.WriteLine("the simple interest for  account FD account  is " + si);
        }

    }
    internal class Program
    {
        public void FindInterest(Account a)
        {
            a.CalculateInterest();

        }
        static void Main(string[] args)
        {
            Program p=new Program();
            Saving s = new Saving(5000,5,3);
            Current c = new Current(1000,10,2);
            FD f = new FD(5000,5,2);
            p.FindInterest(s);
            p.FindInterest(c);
            p.FindInterest(f);
            Console.ReadKey();

        }
    }
}
