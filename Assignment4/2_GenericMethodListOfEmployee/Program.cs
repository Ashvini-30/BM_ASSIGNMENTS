using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collection
{
    
        class Emp
        {
            public int id;
            public string name;
            public Emp(int id, string name)
            {
                this.id = id;
                this.name = name;

            }
        }


        class Program
        {
            static void Main(string[] args)
            {



                List<Emp> listEmp = new List<Emp>();

                


                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("enter employee id  and name ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    string name = Console.ReadLine();
                    Emp e = new Emp(id, name);
                    listEmp.Add(e);
                }


                for (int i = 0; i < listEmp.Count; i++)
                {
                    Emp e = listEmp[i];
                    Console.WriteLine(e.id + " :" + e.name);
                    //Console.WriteLine("\n-------------");
                }


                Console.ReadKey();
            }
        }
    }

