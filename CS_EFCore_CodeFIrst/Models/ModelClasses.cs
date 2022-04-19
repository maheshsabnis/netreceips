using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace CS_EFCore_CodeFIrst.Models
{
    public class Category
    {
        [Key] // Identity Primary Key
        public int CategoryRowId { get; set; }
        [Required]
        [StringLength(20)]
        public string CategoryId { get; set; }
        [Required]
        [StringLength(200)]
        public string CategoryName { get; set; }
        [Required]
        public int BasePrice { get; set; }
        public ICollection<Product> Products { get; set; } // One-To-Many
    }

    public class Product
    {
        [Key] // Identity Primary Key
        public int ProductRowId { get; set; }
        [Required]
        [StringLength(30)]
        public string ProductId { get; set; }
        [Required]
        [StringLength(300)]
        public string Manufacturer { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public int WarrantyYrars { get; set; }
        [Required]
        public int CategoryRowId { get; set; } // Expected to be a Foreign Key
        public Category Category { get; set; } // REferential Integrity One-to-One
    }
}
