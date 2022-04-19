using System;
using System.Collections.Generic;

namespace SharedModels.Models
{
    public partial class Product
    {
        public int ProductRowId { get; set; }
        public string? ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int CategoryRowId { get; set; }

        public virtual Category CategoryRow { get; set; } = null!;
    }
}
