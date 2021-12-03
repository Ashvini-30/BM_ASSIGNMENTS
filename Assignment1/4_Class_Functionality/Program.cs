using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSetProperty
{
    internal class Program
    {
        class Property
        {

            /* Program 4 -->
             * Create class specified in example -3 using properties.
            Call and verify class functionality using main method.*/

            private int empNo;
            private String eName;
                private string designation;
            private float salary;

            public int EmpNo
            {
                get
                {
                    return empNo;
                }

                set
                {
                    empNo = value;
                }
            }

            public string EName
            {
                get
                {
                    return eName;
                }

                set
                {
                    eName = value;
                }
            }

            public string Designation { get; set; }




            public float Salary
            {
                get
                {
                    return salary;
                }

                set
                {
                    salary = value;
                }
            }

        }

        
        
            static void Main(string[] args)
            {
                Property e = new Property();
                e.EmpNo = 1;
                e.EName = "ash";
                e.Designation = "Manager";
                Console.WriteLine("No = {0} Name :- {1}  Designation :- {2}", e.EmpNo, e.EName, e.Designation);

                Console.ReadKey();
            }
        }


    }

