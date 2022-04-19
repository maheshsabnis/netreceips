using System;
using System.Collections.Generic;

#nullable disable

namespace Core_WebApp.Models
{
    public partial class DepartmentTxAudit
    {
        public int AuditId { get; set; }
        public int AuditDeptNo { get; set; }
        public string AuditType { get; set; }
        public DateTime AuditDate { get; set; }
    }
}
