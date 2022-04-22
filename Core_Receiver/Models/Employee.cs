using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Core_Receiver.Models
{
    public partial class Employee
    {
      //  [Key]
        public int EmpNo { get; set; }
        public string EmpName { get; set; } = null!;
    }
}
