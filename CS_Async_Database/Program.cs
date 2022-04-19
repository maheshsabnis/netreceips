using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CS_Async_Database
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TAsk with DB");

            // Connect to Database Asynchronously
            SqlConnection Conn = new SqlConnection("Data Source=.;Initial Catalog=Enterprise;Integrated Security=SSPI");
            // Open the Conection Asynchronously
            // Wait for the Connection
            Conn.OpenAsync().Wait();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conn;
            cmd.CommandText = "Select * from Employee";

            var taskReader = cmd.ExecuteReaderAsync();
            SqlDataReader Reader = taskReader.Result;
            while (Reader.Read()) 
            {
                Console.WriteLine($"EmpNo {Reader["EmpNo"]} EmpNAme: {Reader["EmpName"]}");
            }
            Reader.Close();
            Conn.Close();
            cmd.Dispose();
            Conn.Dispose();
            Console.ReadLine();
        }
    }
}
