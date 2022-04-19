using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace CS_Mutiple_Async
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Muktiple Async Operations in MAin Thread");
            StoreOperations storeOperations = new StoreOperations();
            var Result = storeOperations.GetDataAsync();
            // Instance of DeptEmp
            var deptEmp = Result.Result;
            Console.WriteLine("List of Departments");
            foreach (var item in deptEmp.Departments)
            {
                Console.WriteLine($"DEptNo : {item.DeptNo}, DeptName: {item.DeptName}");
            }
            Console.WriteLine();
            Console.WriteLine("List of Employees");
            foreach (var item in deptEmp.Employees)
            {
                Console.WriteLine($"EmpNo : {item.EmpNo}, EmpName: {item.EmpName}");
            }
            Console.WriteLine();
            Console.WriteLine("File Read");
            var fileDataTask = storeOperations.ReadFileDataAsync();
            Console.WriteLine($"Data in File" +
                $"{fileDataTask.Result}");
            storeOperations.Dispose();
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
        /// a method returning a TAsk Obect of DeptEMp
        /// </summary>
        /// <returns></returns>
        public Task<DeptEmp> GetDataAsync()
        {
            List<Department> depts = new List<Department>();
            List<Employee> emps = new List<Employee>();
            cmdDept = new SqlCommand();
            cmdDept.Connection = _connection;

            cmdDept.CommandText = "Select * from Department";
            var readerDept = cmdDept.ExecuteReader();

            while (readerDept.Read())
            {
                depts.Add(new Department() {
                   DeptNo = Convert.ToInt32(readerDept["DeptNo"]),
                   DeptName = readerDept["DeptName"].ToString(),
                });
            }
            readerDept.Close();

            cmdEmp = new SqlCommand();
            cmdEmp.Connection = _connection;
            cmdEmp.CommandText = "Select * from Employee";
            var readerEmp = cmdEmp.ExecuteReader();
            while (readerEmp.Read())
            {
                emps.Add(new Employee() {
                    EmpNo = Convert.ToInt32(readerEmp["EmpNo"]),
                    EmpName = readerEmp["EmpName"].ToString(),
                });
            }
            readerEmp.Close();
            _connection.Close();
            // Return a TAsk that COntains DeptEmp properties
            return Task.FromResult(new DeptEmp { Departments = depts, Employees = emps });
        }

        public Task<string> ReadFileDataAsync()
        {
            FileStream Fs = new FileStream(@"C:\Coditas\Files\TaskFile.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(Fs);
            string data = sr.ReadToEnd();
            sr.Close();
            sr.Dispose();
            Fs.Close();
            Fs.Dispose();
            return Task.FromResult(data);
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
