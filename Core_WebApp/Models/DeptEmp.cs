using System;
using System.Collections.Generic;

#nullable disable

namespace Core_WebApp.Models
{
    public partial class DeptEmp
    {
        public string DeptName { get; set; }
        public string Location { get; set; }
        public int EmpNo { get; set; }
        public string EmpName { get; set; }
        public int Salary { get; set; }
        public string Designation { get; set; }
    }
}
