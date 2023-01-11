using System.ComponentModel.DataAnnotations;

namespace MvcNewProject.Models
{
    public class LoginModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remenmber me")]
        public bool RememberMe { get; set; }
    }
}
