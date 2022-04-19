using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
#nullable disable

namespace Core_WebApp.Models
{
    public partial class Employee
    {
        [Required]
        [Remote(action: "ValidateEmpNo", controller: "Employee")]
        public int EmpNo { get; set; }
        [Required]
        public string EmpName { get; set; }
        [Required]
        [NonNegative]
        public int Salary { get; set; }
        [Required]
        public string Designation { get; set; }
        [Required]
        public int DeptNo { get; set; }
        [Required]
        public string Email { get; set; }

        public virtual Department DeptNoNavigation { get; set; }
    }
}
