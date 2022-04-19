using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_NetFrwk_AllLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employees emps = new Employees();
            Console.WriteLine("All Extension Methods Together");
            Console.WriteLine("Display all Employees from IT Department in Ascending Order by Salary");
            // In Following Statement Output-of-Previos-Extension-Method will be 
            // Input to Another
            var ItEmpBySalAsc = emps.Where(e => e.DeptName == "IT").AsParallel()
                                    .OrderBy(e => e.Salary)
                                    .Select(e => e);
            PrintResult(ItEmpBySalAsc);

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
