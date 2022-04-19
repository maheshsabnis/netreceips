using System;
using System.Collections.Generic;

namespace CS_EFCore_DbFirst.Models
{
    public partial class DeptEmp
    {
        public string DeptName { get; set; } = null!;
        public string Location { get; set; } = null!;
        public int EmpNo { get; set; }
        public string EmpName { get; set; } = null!;
        public int Salary { get; set; }
        public string Designation { get; set; } = null!;
    }
}
