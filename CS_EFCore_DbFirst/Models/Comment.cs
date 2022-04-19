using System;
using System.Collections.Generic;

namespace CS_EFCore_DbFirst.Models
{
    public partial class Comment
    {
        public int CommentId { get; set; }
        public string Comment1 { get; set; } = null!;
    }
}
