using System;
using CS_AppDeveApproach.Models;
using CS_AppDeveApproach.Services;
namespace CS_AppDeveApproach
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //StackDatabase<int> dbInt = new StackDatabase<int>();
            //dbInt.AddRecord(10);
            //dbInt.AddRecord(20);
            //dbInt.AddRecord(30);

            //// display all records
            //var records = dbInt.GetRecords();

            //foreach (var item in records)
            //{
            //    Console.WriteLine(item);
            //}

            //  StackDatabase<Department> deptDb = new StackDatabase<Department>();

            // Object Initializer
            // used if the class as Properties (precisely Auto-Inplemented Properties)
            // C# 3.0
            //deptDb.AddRecord(new Department() { DeptNo = 10, DeptName = "IT", Location = "Pune", Capacity = 100 });
            //deptDb.AddRecord(new Department() { DeptNo = 20, DeptName = "HR", Location = "Mumbai", Capacity = 10 });
            //deptDb.AddRecord(new Department() { DeptNo = 30, DeptName = "SL", Location = "Banguluru", Capacity = 50 });
            //deptDb.AddRecord(new Department() { DeptNo = 40, DeptName = "AD", Location = "Hyderabad", Capacity = 20 });
            //deptDb.AddRecord(new Department() { DeptNo = 50, DeptName = "AC", Location = "Chennai", Capacity = 40 });


            //var dept = deptDb.GetTopRecord();

            //Console.WriteLine($"{dept.DeptNo} {dept.DeptName} {dept.Location} {dept.Capacity}");

            //var depts = deptDb.GetRecords();

            //foreach (var item in depts)
            //{
            //    Console.WriteLine($"{item.DeptNo} {item.DeptName} {item.Location} {item.Capacity}");
            //}


            IDataOperations<Department, int> deptSrev = new DepartmentService();

            deptSrev.Create(new Department() { DeptNo=10,DeptName="IT", Location="Mumbai", Capacity=1000});
            
            deptSrev.Create(new Department() { DeptNo = 20, DeptName = "HR", Location = "Mumbai", Capacity = 30 });

            var departments = deptSrev.GetAll();

            foreach (var item in departments)
            {
                Console.WriteLine($"{item.DeptNo} {item.DeptName} {item.Location} {item.Capacity}");
            }



            IDataOperations<Employee,int> empServ = new EmployeeService();

           



            Console.ReadLine(); 
        }
    }
}
