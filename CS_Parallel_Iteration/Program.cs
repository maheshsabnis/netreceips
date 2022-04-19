using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CS_Parallel_Iteration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("USing Iteratons");
            // Process EMployees Sequentialy
            var employees = new EmployeeList();

             var startTimerNonParallel = Stopwatch.StartNew();
            for (int i = 0; i < employees.Count; i++)
            {
                employees[i] = ProcessTax.CalculateTax(employees[i]);
                Console.WriteLine($"Non-Parallel Tax for Employee {employees[i].EmpName} is = {employees[i].Tax}");
               // Thread.Sleep(100);
            }
            Console.WriteLine($"Non-Parallel Process completed at {DateTime.Now}" +
               $"Total Time {startTimerNonParallel.Elapsed.TotalSeconds}");

            Console.WriteLine();
            Console.WriteLine("Parallel");
            var startTimerParallel = Stopwatch.StartNew();
            Parallel.For(0, employees.Count, (int i) => { 
                employees[i] = ProcessTax.CalculateTax(employees[i]);
                Console.WriteLine($"Parallel Tax for Employee {employees[i].EmpName} is = {employees[i].Tax}");
                Thread.Sleep(100);
                i++;
            });
            Console.WriteLine($"Non-Parallel Process completed at {DateTime.Now}" +
               $"Total Time {startTimerParallel.Elapsed.TotalSeconds}");

            Console.ReadLine(); 
        }
    }

    public class Employee
    {
        public int EmpNo { get; set; }
        public string EmpName { get; set; }
        public int Salary { get; set; }
        public decimal Tax { get; set; }
    }

    public static class ProcessTax
    {
        public static Employee CalculateTax(Employee emp)
        {
            System.Threading.Thread.Sleep(100);
            emp.Tax = emp.Salary * Convert.ToDecimal(0.4);
            return emp;
        }
    }

    public class EmployeeList : List<Employee>
    {
        public EmployeeList()
        {
            Add(new Employee() { EmpNo = 1, EmpName = "A", Salary = 21000 });
            Add(new Employee() { EmpNo = 2, EmpName = "B", Salary = 22000 });
            Add(new Employee() { EmpNo = 3, EmpName = "C", Salary = 23000 });
            Add(new Employee() { EmpNo = 4, EmpName = "D", Salary = 24000 });
            Add(new Employee() { EmpNo = 5, EmpName = "E", Salary = 25000 });
            Add(new Employee() { EmpNo = 6, EmpName = "F", Salary = 26000 });
            Add(new Employee() { EmpNo = 7, EmpName = "G", Salary = 27000 });
            Add(new Employee() { EmpNo = 8, EmpName = "H", Salary = 28000 });
            Add(new Employee() { EmpNo = 9, EmpName = "I", Salary = 29000 });
            Add(new Employee() { EmpNo = 10, EmpName = "J", Salary = 30000 });
            Add(new Employee() { EmpNo = 11, EmpName = "K", Salary = 31000 });
            Add(new Employee() { EmpNo = 12, EmpName = "L", Salary = 32000 });
            Add(new Employee() { EmpNo = 13, EmpName = "M", Salary = 33000 });
            Add(new Employee() { EmpNo = 14, EmpName = "N", Salary = 34000 });
            Add(new Employee() { EmpNo = 15, EmpName = "O", Salary = 35000 });
            Add(new Employee() { EmpNo = 16, EmpName = "P", Salary = 36000 });
            Add(new Employee() { EmpNo = 17, EmpName = "Q", Salary = 37000 });
            Add(new Employee() { EmpNo = 18, EmpName = "R", Salary = 38000 });
            Add(new Employee() { EmpNo = 19, EmpName = "S", Salary = 39000 });
            Add(new Employee() { EmpNo = 20, EmpName = "T", Salary = 40000 });
            Add(new Employee() { EmpNo = 21, EmpName = "U", Salary = 41000 });
            Add(new Employee() { EmpNo = 22, EmpName = "V", Salary = 42000 });
            Add(new Employee() { EmpNo = 23, EmpName = "W", Salary = 43000 });
            Add(new Employee() { EmpNo = 24, EmpName = "X", Salary = 44000 });
            Add(new Employee() { EmpNo = 25, EmpName = "Y", Salary = 45000 });
            Add(new Employee() { EmpNo = 26, EmpName = "Z", Salary = 46000 });

        }
    }
}
