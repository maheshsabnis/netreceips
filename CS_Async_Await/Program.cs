using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;
namespace CS_Async_Await
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var operations = new StoreOperations();
            var deptEmp = operations.GetDataAsync().Result;
            Console.WriteLine($"Count of Depts {deptEmp.Departments.Count}" +
                $"Count of Employees {deptEmp.Employees.Count}");
            var fileContents = operations.ReadFileDataAsync().Result;
            Console.WriteLine($"File Data = " +
                $"{fileContents}");
            Console.ReadLine();
        }
    }

    internal class StoreOperations : IDisposable
    {
        SqlConnection _connection;
        SqlCommand cmdDept, cmdEmp;
        public StoreOperations()
        {
            _connection = new SqlConnection("Data Source =.; Initial Catalog = Enterprise; Integrated Security = SSPI");
            _connection.Open();
        }

        /// <summary>
        /// a method returning a Obect of DeptEMp aftre resolving
        /// the execution on Threads usig 'await'
        /// The Metod is modified fr Async execution havng an
        /// awaitable statements
        /// </summary>
        /// <returns></returns>
        public async Task<DeptEmp> GetDataAsync()
        {
            List<Department> depts = new List<Department>();
            List<Employee> emps = new List<Employee>();
            cmdDept = new SqlCommand();
            cmdDept.Connection = _connection;

            cmdDept.CommandText = "Select * from Department";
            var readerDept = await cmdDept.ExecuteReaderAsync();

            while (readerDept.Read())
            {
                depts.Add(new Department()
                {
                    DeptNo = Convert.ToInt32(readerDept["DeptNo"]),
                    DeptName = readerDept["DeptName"].ToString(),
                });
            }
            readerDept.Close();

            cmdEmp = new SqlCommand();
            cmdEmp.Connection = _connection;
            cmdEmp.CommandText = "Select * from Employee";
            var readerEmp = await cmdEmp.ExecuteReaderAsync();
            while (readerEmp.Read())
            {
                emps.Add(new Employee()
                {
                    EmpNo = Convert.ToInt32(readerEmp["EmpNo"]),
                    EmpName = readerEmp["EmpName"].ToString(),
                });
            }
            readerEmp.Close();
            _connection.Close();
            return new DeptEmp (){ Departments = depts, Employees = emps };
        }

        public async Task<string> ReadFileDataAsync()
        {
            FileStream Fs = new FileStream(@"C:\Coditas\Files\TaskFile.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(Fs);
            string data = await sr.ReadToEndAsync();
            sr.Close();
            sr.Dispose();
            Fs.Close();
            Fs.Dispose();
            return data;
        }


        public void Dispose()
        {
            _connection.Dispose();
            GC.SuppressFinalize(this);
        }
    }


    internal class Department
    {
        public int DeptNo { get; set; }
        public string DeptName { get; set; }
    }
    internal class Employee
    {
        public int EmpNo { get; set; }
        public string EmpName { get; set; }
    }

    internal class DeptEmp
    {
        public List<Department> Departments { get; set; }
        public List<Employee> Employees { get; set; }
    }

}
