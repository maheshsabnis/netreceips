using System;
using System.Collections.Generic;

namespace CS_LINQ_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employees emps = new Employees();
            Console.WriteLine("Using LINQ");

            Console.WriteLine("List of Employees in IT DeptName using LINQ");

            //foreach (var emp in emps)
            //{
            //    if (emp.DeptName == "IT" && emp.Salary >=8000)
            //    {
            //        Console.WriteLine($"{emp.EmpNo} {emp.EmpName}");
            //    }
            //}
            Console.WriteLine("Enter DeptName");
            string dname = Console.ReadLine();
            var empsByDname = emps.FindAll(e => e.DeptName == dname && e.Salary>8000);

            foreach (var item in empsByDname)
            {
                Console.WriteLine($"{item.EmpNo} {item.EmpName}");
            }
            



            Console.ReadLine();
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
            Add(new Employee() { EmpNo = 101, EmpName = "Mahesh", DeptName = "IT", Salary = 11000});
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
