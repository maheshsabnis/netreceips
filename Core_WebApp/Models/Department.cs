using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


#nullable disable

namespace Core_WebApp.Models
{
    public partial class Department
    {
        public Department()
        {
            Employees = new HashSet<Employee>();
        }
        [Required(ErrorMessage ="DeptNo is Required")]
        [Remote("ValidateDeptNoUnique", "Department", ErrorMessage ="MUST be Unique")]
        public int DeptNo { get; set; }
        [Required(ErrorMessage = "DeptName is Required")]
        public string DeptName { get; set; }
        [Required(ErrorMessage = "Location is Required")]
        public string Location { get; set; }
        [Required(ErrorMessage = "Capacity is Required")]
        [NonNegative(ErrorMessage = "Capacity Cannot be -ve")]
        public int Capacity { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
