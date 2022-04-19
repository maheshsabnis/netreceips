using System;
using System.Collections.Generic;

namespace CS_EFCore_DbFirst.Models
{
    public partial class EmployeeAudit
    {
        public int AuditId { get; set; }
        public int AuditEmpNo { get; set; }
        public DateTime AudiDate { get; set; }
    }
}
