using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace CS_Collection_Serialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Serializing Collection");

            FileStream fs = new FileStream(@"c:\Coditas\Files\Employees.dat", FileMode.CreateNew, FileAccess.Write);
            BinaryFormatter formatter = new BinaryFormatter();

            Employees employees = new Employees();

            formatter.Serialize(fs, employees);


            Console.WriteLine("Serialization Done");

            fs.Close();

            fs = new FileStream(@"c:\Coditas\Files\Employees.dat", FileMode.Open, FileAccess.Read);

            Employees emps = (Employees)formatter.Deserialize(fs);

            foreach (var e in emps)
            {
                Console.WriteLine($"{e.EmpNo} {e.EmpName} {e.DeptName} {e.Salary}");
            }

            Console.ReadLine();
        }
    }

    [Serializable]
    internal class Employee
    {
        public int EmpNo { get; set; }
        public string EmpName { get; set; }
        public string DeptName { get; set; }
        public int Salary { get; set; }
    }

    [Serializable]
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
