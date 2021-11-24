using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ADOExample1
{
    internal class Program
    {
        class EmployeeInfo
        {
            public SqlDataReader GetEmployeeData()
            {
                SqlConnection con = null;
                SqlCommand cmd = null;
                SqlDataReader reader = null;
                try
                {
                    //create and open connection
                    con = new SqlConnection();
                    con.ConnectionString = "Server=.; Database=EmployeeDB;trusted_connection=true";
                    con.Open();

                    //create command
                    cmd = new SqlCommand("GetEmployeeData", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    //execute command and get data
                     reader = cmd.ExecuteReader();
                    while (reader.Read())
                     {
                         Console.WriteLine(reader[0].ToString() + "\t" + reader[1].ToString() + "\t" + reader[2].ToString() + "\t" + reader[3].ToString() + "\t" + reader[4].ToString() + "\t");
                     }
                    //Console.ReadKey();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                /*  finally
                  {
                      con.Close();
                  }*/
                return reader;

            }
            public SqlDataReader GetInfoById(string empno)
            {
                SqlConnection con = null;
                SqlCommand cmd = null;
                SqlDataReader reader = null;
                try
                {
                    //create and open connection
                    con = new SqlConnection();
                    con.ConnectionString = "Server=.; Database=EmployeeDB;trusted_connection=true";
                    con.Open();

                    //create command
                    cmd = new SqlCommand("GetInfoById", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter param = new SqlParameter("empno", empno);
                    cmd.Parameters.Add(param);
                    reader = cmd.ExecuteReader();

                    //execute command and get data
                    // SqlDataReader reader = cmd.ExecuteReader();
                    /* while (reader.Read())
                     {
                         Console.WriteLine(reader[0].ToString() + "\t" + reader[1].ToString() + "\t" + reader[2].ToString() + "\t" + reader[3].ToString() + "\t" + reader[4].ToString() + "\t");
                     }*/
                    //Console.ReadKey();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                return reader;

            }
            public int InsertEmployee(int empno, string ename, string Designation, double salary, int deptno)
            {
                SqlConnection con = null;
                SqlCommand cmd = null;
                int res = 0;

                try
                {

                    //create and open connection
                    con = new SqlConnection();
                    con.ConnectionString = "Server=.; Database=EmployeeDB;trusted_connection=true";
                    con.Open();

                    //create command
                    cmd = new SqlCommand("InsertEmployee", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter param1 = new SqlParameter("empno", empno);
                    SqlParameter param2 = new SqlParameter("ename", ename);
                    SqlParameter param3 = new SqlParameter("designation", Designation);
                    SqlParameter param4 = new SqlParameter("salary", salary);
                    SqlParameter param5 = new SqlParameter("deptno", deptno);

                    cmd.Parameters.Add(param1);
                    cmd.Parameters.Add(param2);
                    cmd.Parameters.Add(param3);
                    cmd.Parameters.Add(param4);
                    cmd.Parameters.Add(param5);

                    res = cmd.ExecuteNonQuery();

                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
                return res;

            }
            public int UpdateInfo(int empno, string ename, string Designation, double salary, int deptno)
            {
                SqlConnection con = null;
                SqlCommand cmd = null;
                int res = 0;

                try
                {

                    //create and open connection
                    con = new SqlConnection();
                    con.ConnectionString = "Server=.; Database=EmployeeDB;trusted_connection=true";
                    con.Open();

                    //create command
                    cmd = new SqlCommand("UpdateInfo", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter param1 = new SqlParameter("empno", empno);
                    SqlParameter param2 = new SqlParameter("ename", ename);
                    SqlParameter param3 = new SqlParameter("designation", Designation);
                    SqlParameter param4 = new SqlParameter("salary", salary);
                    SqlParameter param5 = new SqlParameter("deptno", deptno);

                    cmd.Parameters.Add(param1);
                    cmd.Parameters.Add(param2);
                    cmd.Parameters.Add(param3);
                    cmd.Parameters.Add(param4);
                    cmd.Parameters.Add(param5);

                    res = cmd.ExecuteNonQuery();

                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
                return res;

            }
            public int DeleteEmpInfo(int empno)
            {
                SqlConnection con = null;
                SqlCommand cmd = null;
                int res = 0;

                try
                {

                    //create and open connection
                    con = new SqlConnection();
                    con.ConnectionString = "Server=.; Database=EmployeeDB;trusted_connection=true";
                    con.Open();

                    //create command
                    cmd = new SqlCommand("DeleteEmpInfo", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter param1 = new SqlParameter("empno", empno);


                    cmd.Parameters.Add(param1);


                    res = cmd.ExecuteNonQuery();

                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
                return res;

            }
            public void PrintReader(SqlDataReader reader)
            {
                while (reader.Read())
                {
                    Console.WriteLine(reader[0].ToString() + "\t" + reader[1].ToString() + "\t" + reader[2].ToString() + "\t" + reader[3].ToString() + "\t" + reader[4].ToString() + "\t");
                }


            }
        }
            static void Main(string[] args)
        {
            int choice;
            EmployeeInfo em = new EmployeeInfo();
            do
            {

                Console.WriteLine("menu");
                Console.WriteLine("1.Get details of all employee");
                Console.WriteLine("2.get details of all  Employee based on empno");
                Console.WriteLine("3.Insert the details of Employee");
                Console.WriteLine("4.Update The details of employee");
                Console.WriteLine("5.Delete employee details");
                Console.WriteLine("Enter your choice");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        em.PrintReader(em.GetEmployeeData());
                        break;

                    case 2:
                        Console.WriteLine("Enter employee no");
                        int empno = Convert.ToInt32(Console.ReadLine());
                        em.PrintReader(em.GetInfoById(empno.ToString()));
                        break;
                    case 3:
                        Console.WriteLine("Enter employee no");
                        int empno1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter employee name");
                        string ename = Console.ReadLine();
                        Console.WriteLine("Enter employee designation");
                        string designation = Console.ReadLine();
                        Console.WriteLine("Enter employee salary");
                        int salary = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter employee dept no");
                        int deptno = Convert.ToInt32(Console.ReadLine());
                        em.UpdateInfo(empno1, ename, designation, salary, deptno);
                        Console.WriteLine("Data Inserted successfully");
                        break;
                    case 4:
                        Console.WriteLine("Enter employee no");
                        int empno3 = Convert.ToInt32(Console.ReadLine());
                        em.DeleteEmpInfo(empno3);
                        Console.WriteLine("Data deleted successfully");

                        break;
                    default:
                        Console.WriteLine("please enter valid choice");
                        break;

                }
                Console.WriteLine("Enter 'Y' or 'y' to continue");
                choice = Convert.ToChar(Console.ReadLine());

            } while (choice == 'y' || choice == 'Y');






            Console.ReadKey();
        }
    }
}
