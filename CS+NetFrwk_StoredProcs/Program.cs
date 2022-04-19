using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CS_NetFrwk_StoredProcs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Working with Stored Procs");
            SqlConnection Conn = new SqlConnection("Data Source=.;Initial Catalog=Enterprise;Integrated Security=SSPI");

            Conn.Open();
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Conn;
            // The CommandText will have Stored Procedure
            Cmd.CommandText = "sp_getEmployees";
            // Inform the Command Object that the above value is Stored Procedure
            Cmd.CommandType = CommandType.StoredProcedure;
            // Execute the Command 
            // Use DataReader because the SP is returning rows
            SqlDataReader Reader = Cmd.ExecuteReader();
            while (Reader.Read())
            {
                Console.WriteLine($"{Reader["EmpNo"]}, {Reader["EmpName"]}");
            }
            Reader.Close();


            // Perform Insert Operation using SP
            Cmd.CommandType=CommandType.StoredProcedure;
            Cmd.CommandText = "sp_InsertDepartment";
            // Pass Parameters
            // Either Create SaqlParameter class instance and create each Parameter separately
            // Note: Refer DepartmentDataAccess from CS_NetFrwk_ConnectedApp Project

            SqlParameter pDeptNo = new SqlParameter();
            pDeptNo.ParameterName = "@DeptNo";
            pDeptNo.SqlDbType = SqlDbType.Int;
            pDeptNo.Direction = ParameterDirection.Input;
            pDeptNo.Value = 110;


            SqlParameter pDeptName = new SqlParameter();
            pDeptName.ParameterName = "@DeptName";
            pDeptName.SqlDbType = SqlDbType.VarChar;
            pDeptName.Size = 200;
            pDeptName.Direction = ParameterDirection.Input;
            pDeptName.Value = "Customer Service";

            SqlParameter pLocation = new SqlParameter();
            pLocation.ParameterName = "@Location";
            pLocation.SqlDbType = SqlDbType.VarChar;
            pLocation.Size = 200;
            pLocation.Direction = ParameterDirection.Input;
            pLocation.Value = "Mumbai";

            SqlParameter pCapacity = new SqlParameter();
            pCapacity.ParameterName = "@Capacity";
            pCapacity.SqlDbType = SqlDbType.Int;
            pCapacity.Direction = ParameterDirection.Input;
            pCapacity.Value = 200;

            // Add parameters into the Parameters Collection of the Command object
            Cmd.Parameters.Add(pDeptNo);
            Cmd.Parameters.Add(pDeptName);
            Cmd.Parameters.Add(pLocation);
            Cmd.Parameters.Add(pCapacity);

            // Execute the Command Object
            int Res = Cmd.ExecuteNonQuery();
            if (Res != 0)
            {
                Console.WriteLine("Insert is Successful");
            }

            Conn.Close();
            Console.WriteLine("Ends Here");
            Console.ReadLine();
        }
    }
}
