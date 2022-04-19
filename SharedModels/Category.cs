using System;
using System.Collections.Generic;

namespace SharedModels.Models
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public int CategoryRowId { get; set; }
        public string CategoryId { get; set; } = null!;
        public string CategoryName { get; set; } = null!;
        public int BasePrice { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
