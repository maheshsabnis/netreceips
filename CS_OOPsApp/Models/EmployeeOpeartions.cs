using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_OOPsApp.Models
{
    /// <summary>
    /// Employee Operations class
    /// </summary>
    internal class EmployeeOpeartions
    {
        private List<Employee> Employees;
        public EmployeeOpeartions()
        {
            Employees = new List<Employee>();
        }

        public List<Employee> GetEmployees()
        {
            return Employees;
        }

        public List<Employee> AddEmployee(Employee emp)
        {
            Employees.Add(emp);
            return Employees;
        }

        public List<Employee> UpdateEmployee(int eno, Employee emp)
        {
            // use foreach loop to search employee
            // If not found throw exception
            // Else Updated searche employee by the emp object 
            return Employees;
        }

    }
}
