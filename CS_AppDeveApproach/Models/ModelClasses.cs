using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_AppDeveApproach.Models
{
    internal class Department
    {
        public int DeptNo { get; set; }
        public string DeptName { get; set; }
        public string Location { get; set; }
        public int Capacity { get; set; }
    }

    internal class Employee
    {
        public int EmpNo { get; set; }
        public string EmpName { get; set; }
        public string Designation { get; set; }
        public int Salary { get; set; }
        public int DeptNo { get; set; }
    }
}
