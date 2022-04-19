using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient; 
namespace CS_NetFrwkRelations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Using Data Relations");
            SqlConnection Conn = new SqlConnection("Data Source=.;Initial Catalog=Enterprise;Integrated Security=SSPI");
            SqlDataAdapter AdDept = new SqlDataAdapter("Select * from Department", Conn);
            SqlDataAdapter AdEmp = new SqlDataAdapter("Select * from Employee", Conn);
            DataSet Ds = new DataSet();
            AdDept.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            AdEmp.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            AdDept.Fill(Ds, "Department");
            AdEmp.Fill(Ds, "Employee");

            DataRelation DeptEmp = new DataRelation(
                  "DeptEmp", Ds.Tables["Department"].Columns["DeptNo"],
                  Ds.Tables["Employee"].Columns["DeptNo"]
                );

            Ds.Relations.Add(DeptEmp);


            // Navigate from Parent-to-Child

            // cound of records from the Department Table (Parent Table)
            var parentRowsCount = Ds.Tables["Department"].Rows.Count;
            for (int i = 0; i < parentRowsCount; i++)
            { 
                // Get a row from the parent
                DataRow drParent = Ds.Tables["Department"].Rows[i];
                Console.WriteLine($"Parent Row" +
                    $"DeptNo={drParent["DeptNo"]}, DeptName={drParent["DeptName"]}, Location={drParent["Location"]}, Capacity={drParent["Capacity"]}");
                // Now get child rows
                foreach (DataRow drChild in drParent.GetChildRows(DeptEmp))
                {
                    Console.WriteLine($"EmpNo={drChild["EmpNo"]}, EmpName={drChild["EmpName"]}, Salary={drChild["Salary"]}, Designation={drChild["Designation"]}, DeptNo={drChild["DeptNo"]}");
                }
            }

            Console.ReadLine(); 
        }
    }
}
