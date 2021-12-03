using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IODemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo di = new DirectoryInfo("C:\\Users\\Jay Gajanan\\Documents\\Benchmark_Training.net\\IODemo");
            if(di.Exists)
            {
                Console.WriteLine(di.FullName);
                Console.WriteLine(di.CreationTime);
                Console.WriteLine(di.Parent);
            }
            else
            {
                di.Create();
                Console.WriteLine("Directory created");
            }
            Console.ReadKey();

        }
    }
}
