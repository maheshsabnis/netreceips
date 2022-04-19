using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CS_NetFrwk_SP_OutoutParameter
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
            Cmd.CommandText = "sp_GetSumSalaryByDeptNoWithOutParamNew";
            // Inform the Command Object that the above value is Stored Procedure
            Cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter pDeptNo = new SqlParameter();
            pDeptNo.ParameterName = "@DeptNo";
            pDeptNo.SqlDbType = SqlDbType.Int;
            pDeptNo.Direction = ParameterDirection.Input;
            pDeptNo.Value = 10;
            Cmd.Parameters.Add(pDeptNo);
            // Define a SqlParameter as Output Direction
            SqlParameter pResult = new SqlParameter();
            pResult.ParameterName = "@Result";
            pResult.SqlDbType = SqlDbType.Int;
            pResult.Direction = ParameterDirection.Output;
            // pResult.Value =0;
            Cmd.Parameters.Add(pResult);

            // Execute the Stored Proc
            // We are using ExecuteScalar() because the SP return 
            // a Single result
              Cmd.ExecuteScalar();

            Console.WriteLine($"Sum of Salary for all Employee of DeptNo as {pDeptNo.Value} is = {pResult.Value}");

            Console.ReadLine(); 
        }
    }
}
