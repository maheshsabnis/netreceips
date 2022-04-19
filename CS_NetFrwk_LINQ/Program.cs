using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_NetFrwk_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employees employees = new Employees();
            Console.WriteLine("Using LINQ");
            // Print All Employees
            var allemps = employees.Select(e => e);
            PrintResult(allemps);


            Console.WriteLine("Enter DeptName");
            string dname = Console.ReadLine();
            var emps = employees.Where(e=>e.DeptName == dname);
            PrintResult(emps);

            Console.WriteLine();
            Console.WriteLine("Print All Employee Order By Salary Ascending");

            var orderBySalAsc = employees.OrderBy(e => e.Salary);
            PrintResult(orderBySalAsc);

            Console.WriteLine("Print All Employee Order By Salary Descending");

            var orderBySalDesc = employees.OrderByDescending(e => e.Salary);
            PrintResult(orderBySalDesc);

            Console.WriteLine("Group by DeptName");
            // Group By will for a 'Key' which represents a Group Name
            // The group has a collection in it which can be operatred
            //Console.WriteLine("Enter DeptName");
            //var d = Console.ReadLine();
            var groupByDname = employees.GroupBy(e => e.DeptName);

            foreach (var item in groupByDname)
            {
                Console.WriteLine(item.Key);
                PrintResult(item.ToList());    
            }


            Console.ReadLine(); 
        }

        static void PrintResult(IEnumerable<Employee> emps)
        {
            foreach (var item in emps)
            {
                Console.WriteLine($"{item.EmpNo} {item.EmpName} {item.DeptName} {item.Salary}");
            }
        }
    }


    internal class Employee
    {
        public int EmpNo { get; set; }
        public string EmpName { get; set; }
        public string DeptName { get; set; }
        public int Salary { get; set; }
    }


    internal class Employees : List<Employee>
    {
        public Employees()
        {
            Add(new Employee() { EmpNo = 101, EmpName = "Mahesh", DeptName = "IT", Salary = 11000 });
            Add(new Employee() { EmpNo = 102, EmpName = "Tejas", DeptName = "HR", Salary = 12000 });
            Add(new Employee() { EmpNo = 103, EmpName = "Nandu", DeptName = "SL", Salary = 13000 });
            Add(new Employee() { EmpNo = 104, EmpName = "Anil", DeptName = "IT", Salary = 14000 });
            Add(new Employee() { EmpNo = 105, EmpName = "Jaywant", DeptName = "HR", Salary = 10000 });
            Add(new Employee() { EmpNo = 106, EmpName = "Abhay", DeptName = "SL", Salary = 9000 });
            Add(new Employee() { EmpNo = 107, EmpName = "Anil", DeptName = "IT", Salary = 8000 });
            Add(new Employee() { EmpNo = 108, EmpName = "Shyam", DeptName = "HR", Salary = 7000 });
            Add(new Employee() { EmpNo = 109, EmpName = "Vikram", DeptName = "SL", Salary = 6000 });
            Add(new Employee() { EmpNo = 110, EmpName = "Suprotim", DeptName = "IT", Salary = 5000 });
        }
    }
}
