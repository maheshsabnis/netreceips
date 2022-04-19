using System;
using System.Collections.Generic;

namespace CS_EFCore_DbFirst.Models
{
    public partial class User
    {
        public int UserId { get; set; }
        public string? UserName { get; set; }
        public string Password { get; set; } = null!;
    }
}
