using System.ComponentModel.DataAnnotations;

namespace Blazor_Wasm.Models
{
    public class LoginUser
    {
        [Required(ErrorMessage = "User Name is Must")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is Must")]
        public string Password { get; set; }
    }

    public class RegisterUser
    {
        [Required(ErrorMessage = "Email is Must")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password is Must")]
        [RegularExpression("^((?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])|(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[^a-zA-Z0-9])|(?=.*?[A-Z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])|(?=.*?[a-z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])).{8,}$",
            ErrorMessage = "Passwords must be minimum 8 characters and must be string password with uppercase character, number and sepcial character")]
        public string Password { get; set; }
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }

    public class ResponseData
    {
        public string Message { get; set; }
    }

    public class CategoryResponse
    {
        [Key]
        public int CategoryRowId { get; set; }
        [Required]
        [StringLength(50)]
        public string? CategoryId { get; set; }
        [Required]
        [StringLength(100)]
        public string? CategoryName { get; set; }
        [Required]
        public int BasePrice { get; set; }
        public ICollection<Product>? Products { get; set; }
    }
}
