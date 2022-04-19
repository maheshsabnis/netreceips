using System;

using System.Collections.Generic;
using CS_OOPsApp.Models;
namespace CS_OOPsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // reference
            EmployeeOpeartions operation = null;
            // instance creation (aka Object definition)
             operation = new EmployeeOpeartions();
            List<Employee> employees = new List<Employee>();

            Employee emp = AcceptEmployeeData();

            employees =  operation.AddEmployee(emp);

            PrintEmployees(ref employees);


            Console.ReadLine();
        }

        /// <summary>
        /// Method that returns Employee Object
        /// </summary>
        /// <returns></returns>
        static Employee AcceptEmployeeData()
        {
            Employee employee = new Employee();
            Console.WriteLine("Enter EmpNo");
            employee.EmpNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter EmpName");
            employee.EmpName = Console.ReadLine();
            Console.WriteLine("Enter DeptName");
            employee.DeptName = Console.ReadLine();
            Console.WriteLine("Enter Designation");
            employee.Designation = Console.ReadLine();
            Console.WriteLine("Enter Salary");
            employee.Salary = Convert.ToInt32(Console.ReadLine());
            return employee;
        }

        static void PrintEmployees(ref List<Employee> emps)
        {
            Console.WriteLine("EmpNo \t\t EmpName \t DeptName \t Designation \t Salary");
            foreach (Employee emp in emps)
            {
                Console.WriteLine($"{emp.EmpNo} \t\t {emp.EmpName} \t {emp.DeptName} \t {emp.Designation} \t {emp.Salary}");
            }
        }
    }
}
