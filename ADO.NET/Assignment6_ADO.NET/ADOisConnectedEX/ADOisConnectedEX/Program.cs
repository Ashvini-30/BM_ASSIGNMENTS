using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ADOisConnectedEX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int choice;
                char ch;
                SqlConnection con = new SqlConnection("Server=.;Database=EmployeeDB;trusted_connection=true");
                SqlCommand cmd = new SqlCommand("Select * from Course", con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Course");
                DataTable tab = ds.Tables["Course"];
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                do
                {
                    Console.WriteLine("Menu");
                    Console.WriteLine("1.Print all the course");
                    Console.WriteLine("2.Print course based on course id");
                    Console.WriteLine("3.Insert course details");
                    Console.WriteLine(" 4.Update course details");
                    Console.WriteLine("5.delete course details");
                    Console.WriteLine("Enter your choice");
                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            foreach (DataRow row in tab.Rows)
                            {
                                Console.WriteLine(row[0].ToString() + " " + row[1].ToString() + " " + row[2].ToString() + " " + row[3].ToString());
                            }
                            Console.ReadKey();
                            break;

                        case 2:
                            Console.WriteLine("Enter courseID");
                            int cid = Convert.ToInt32(Console.ReadLine());
                            DataRow[] rows = tab.Select("CourseId=" + cid);
                            Console.WriteLine("Course details are");
                            foreach (DataRow row in rows)
                            {
                                Console.WriteLine(row[0].ToString() + " " + row[1].ToString() + " " + row[2].ToString() + " " + row[3].ToString());


                            }
                            break;
                        case 3:
                            Console.WriteLine("Enter courseid");
                            int cid1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter course name");
                            string cname = Console.ReadLine();
                            Console.WriteLine("enter Instructor name");
                            string ins = Console.ReadLine();
                            Console.WriteLine("Enter fees");
                            double fees = Convert.ToDouble(Console.ReadLine());
                            DataRow NewRow = tab.NewRow();
                            NewRow["CourseId"] = cid1;
                            NewRow["CName"] = cname;
                            NewRow["instructor"] = ins;
                            NewRow["fees"] = fees;
                            tab.Rows.Add(NewRow);
                            adapter.Update(tab);
                            Console.WriteLine("Record inserted into the table");
                            break;

                        case 4:
                            Console.WriteLine("Enter courseid");
                            int cid2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter course name");
                            string cname2 = Console.ReadLine();
                            Console.WriteLine("enter Instructor name");
                            string ins2 = Console.ReadLine();
                            Console.WriteLine("Enter fees");
                            double fees2 = Convert.ToDouble(Console.ReadLine());
                            DataRow[] ro = tab.Select("CourseId=" + cid2);
                            DataRow rowupdate = ro[0];
                            rowupdate["courseid"] = cid2;
                            rowupdate["CName"] = cname2;
                            rowupdate["instructor"] = ins2;
                            rowupdate["fees"] = fees2;

                            adapter.Update(tab);
                            Console.WriteLine("Record updated successfully");
                            break;

                         case 5:
                             Console.WriteLine("enter courseid");
                             int cid3=Convert.ToInt32(Console.ReadLine());
                             DataRow[] rod = tab.Select("CourseId= " + cid3);
                             DataRow rowdelete= rod[0];
                              rowdelete.Delete();
                        adapter.Update(ds,"Course");
                        
                        Console.WriteLine("Record deleted succesfully");
                        break;
                        
                        default:
                            Console.WriteLine("Invalid case");
                            break;
                    }
                           
                    Console.WriteLine("Enter 'Y' or 'y' to continue ");
                            ch = Convert.ToChar(Console.ReadLine());
                    








                    } while (ch=='Y' || ch=='y') ;
                }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            

            

        }
    }
}
