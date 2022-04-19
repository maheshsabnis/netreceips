using System;
using System.Collections.Generic;

namespace CS_EFCore_DbFirst.Models
{
    public partial class DepartmentTxAudit
    {
        public int AuditId { get; set; }
        public int AuditDeptNo { get; set; }
        public string AuditType { get; set; } = null!;
        public DateTime AuditDate { get; set; }
    }
}
