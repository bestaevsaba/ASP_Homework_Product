using System.ComponentModel.DataAnnotations;

namespace ASP_Homework_Product.Models
{
    public class Register
    {
        [Required]
        [EmailAddress]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}
