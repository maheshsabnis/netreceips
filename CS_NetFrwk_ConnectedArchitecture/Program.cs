using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 1. Import the NAmespace for Database Programming
using System.Data;
using System.Data.SqlClient;

namespace CS_NetFrwk_ConnectedArchitecture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Using the ADO.NET Connected Architecture");

            try
            {
                // 2. Create an Instance of the SqlConnection class
                SqlConnection Conn = new SqlConnection();
                // 2.a. Set the Connection String
                Conn.ConnectionString = "Data Source=.;Initial Catalog=Enterprise;Integrated Security=SSPI";
                // 2.b. Open the Connection
                Conn.Open();

                // 3. Define a Command Object
                SqlCommand Cmd = new SqlCommand();
                // 3.a. Pass the Connection Object, so that the Commd know to which
                // database to connect
                Cmd.Connection = Conn;
                // 3.b. Set the Command Text, the Statement to be executed
                Cmd.CommandText = "Select * from Department";
                // 3.c. Execute the Command
                SqlDataReader Reader = Cmd.ExecuteReader();
                // 3.d. Iterate over the reader to read data
                while (Reader.Read())
                {
                    Console.WriteLine($"DeptNo: {Reader["DeptNo"]}, DeptName: {Reader["DeptName"]}, Location: {Reader["Location"]}, Capacity: {Reader["Capacity"]}");
                }
                // 3.e. Close the Reader
                  Reader.Close(); // Not Closing Reader
                Cmd.CommandText = "Select * from Employee";
                Reader = Cmd.ExecuteReader();
                while (Reader.Read())
                {
                    Console.WriteLine($"EmpNo: {Reader["EmpNo"]}, EmpName: {Reader["EmpName"]}, Salary: {Reader["Salary"]}, Designation: {Reader["Designation"]}, DeptNo: {Reader["DeptNo"]}, Email: {Reader["Email"]}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Occured {ex.Message}");
            }
           


            Console.ReadLine(); 
        }
    }
}
