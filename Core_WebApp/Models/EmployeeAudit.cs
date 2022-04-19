using System;
using System.Collections.Generic;

#nullable disable

namespace Core_WebApp.Models
{
    public partial class EmployeeAudit
    {
        public int AuditId { get; set; }
        public int AuditEmpNo { get; set; }
        public DateTime AudiDate { get; set; }
    }
}
