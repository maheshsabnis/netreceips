using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CS_NetFrwk_Disconnected
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ADO.NET Disconnected Architecture");

            // 1. Create a Connection
            SqlConnection Conn = new SqlConnection("Data Source=.;Initial Catalog=Enterprise;Integrated Security=SSPI");
            // 2. Create Data Adapter with The Select Command (Plain Select Statement) and 
            // the Connection Object
            // This will internally call Conn.Open() to open the connection
            SqlDataAdapter AdDept = new SqlDataAdapter("Select * from Department", Conn);
            SqlDataAdapter AdEmp =  new SqlDataAdapter("Select * from Employee", Conn);

            // 3. Create a DataSet Instance
            DataSet Ds = new DataSet();
            // 3.a. Lets Convert UnTyped DataSet Into the Typed DataSet
            // This will be required to search records based on Primary key
            // using the Find() method of the DaraRowCollection
            AdDept.MissingSchemaAction = MissingSchemaAction.AddWithKey; 
            AdEmp.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            // 4. Fill data in DataSet
            // The Name of the Table on Db Server is given to table created 
            // in dataset
            // This will be UnTyped DataSet By Default
            AdDept.Fill(Ds, "Department");
            AdEmp.Fill(Ds, "Employee");


            #region Commented code for Xml Schema, Data, Table Names, Rows, Columns

            // Print Table Schme in Xml Format
            //Console.WriteLine($"Schema = " +
            //   $"{Ds.GetXmlSchema()}");
            //Console.WriteLine();
            //Console.WriteLine($"Data in Xml Form" +
            //    $"{Ds.GetXml()}");

            //Console.WriteLine($"Number of Tables in DataSet = {Ds.Tables.Count} " +
            //    $"And Table Name = {Ds.Tables[0].TableName}");

            //DataTableCollection dataTables = Ds.Tables;

            //foreach (DataTable Dt in dataTables)
            //{
            //    Console.WriteLine($"Data Table Name = {Dt.TableName}");
            //}

            //Console.WriteLine();

            //Console.WriteLine("List of Columns");

            //DataColumnCollection dataColumns = Ds.Tables["Department"].Columns;

            //foreach (DataColumn column in dataColumns)
            //{
            //    Console.WriteLine($"Name of the Column is = {column.ColumnName}");
            //}
            //Console.WriteLine();
            //Console.WriteLine("List of Records from Department Table");
            //DataRowCollection dataRows = Ds.Tables["Department"].Rows;

            //foreach (DataRow row in dataRows)
            //{
            //    Console.WriteLine($"{row["DeptNo"]}     {row["DeptName"]}       {row["location"]}       {row["Capacity"]}");
            //}
            #endregion

            #region Add new record in Department Table
            //  AddRecord(ref Ds, ref AdDept);
            #endregion

            #region Update the Record
            // UpdateRecord(ref Ds, ref AdDept);
            #endregion

            #region Delete Record
            // DeleteRecord(ref Ds, ref AdDept);
            #endregion

            #region Relationship Across Table
            GetDataRelation(ref Ds);
            #endregion


            Console.ReadLine();
        }

        static void AddRecord( ref DataSet Ds, ref SqlDataAdapter AdDept)
        {
            // 1. Create a new Row in the Department DataTable in DataSet
            DataRow DrNew = Ds.Tables["Department"].NewRow();
            // 2. Set data for all columns for the row
            DrNew["DeptNo"] = 100;
            DrNew["DeptName"] = "Software";
            DrNew["Location"] = "Hyderabad";
            DrNew["Capacity"] = 140;
            // 3. Add the Row into the Table
            Ds.Tables["Department"].Rows.Add(DrNew);
            // 4. Define a Command Builder to Ask the Adpater to Update Record in Database Table
            SqlCommandBuilder bldr1 = new SqlCommandBuilder(AdDept);
            // 5. Call Update
            AdDept.Update(Ds, "Department");
        }

        static void UpdateRecord(ref DataSet Ds, ref SqlDataAdapter AdDept)
        {
            //1. Search Record BAsed on Primary Key
            DataRow DrFind = Ds.Tables["Department"].Rows.Find(90);
            // 2. Update its Values
            DrFind["Location"] = "Hyderabad-SanathNagar";
            // 3. Command Build and Update
            SqlCommandBuilder bldr2 = new SqlCommandBuilder(AdDept);
            AdDept.Update(Ds, "Department");
        }

        static void DeleteRecord(ref DataSet Ds, ref SqlDataAdapter AdDept)
        {
            //1. Search Record BAsed on Primary Key
            DataRow DrFind = Ds.Tables["Department"].Rows.Find(110);
            // 2. Call Delete() method on the searched record
            DrFind.Delete();
            // 3. Command Build and Update
            SqlCommandBuilder bldr2 = new SqlCommandBuilder(AdDept);
            AdDept.Update(Ds, "Department");
        }

        static void GetDataRelation(ref DataSet Ds)
        {
            // 1. Create a reation Object
            DataRelation DeptEmp = new DataRelation("DeptEmp", Ds.Tables["Department"].Columns["DeptNo"], Ds.Tables["Employee"].Columns["DeptNo"]);
            // 2. Add this Relation in DataSet
            Ds.Relations.Add(DeptEmp);

            // 3. Print Employees for Each Department

            // 3.a. Get Count of Rows for Department

            int DeptRowCount = Ds.Tables["Department"].Rows.Count;

            // 3.b. Iterate Over the COunt of Rows and read child data
            for (int i = 0; i < DeptRowCount; i++)
            { 
                // 3.b.1. Print the Parent Table Row Details
                DataRow parentRow = Ds.Tables["Department"].Rows[i];
                Console.WriteLine($"DeptNo: {parentRow["DeptNo"]} DeptName: DeptNo: {parentRow["DeptName"]}");
                // 3.b.2. For Each Parent Row Read Child Table Rows using the Data Relation
                foreach (DataRow childRow in parentRow.GetChildRows(DeptEmp))
                {
                    // 3.b.3. Print Child Rows
                    Console.WriteLine($"EmpNo: {childRow["EmpNo"]}, EmpName: {childRow["EmpName"]}, Salary:{childRow["Salary"]}, Designation:{childRow["Designation"]}, DeptNo:{childRow["DeptNo"]}");
                }
                Console.WriteLine();
            }

        }

    }
}
