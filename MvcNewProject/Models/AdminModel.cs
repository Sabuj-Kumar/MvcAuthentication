using System.ComponentModel.DataAnnotations;

namespace MvcNewProject.Models
{
    public class AdminModel
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public string? Role { get; set; }
    }
}
