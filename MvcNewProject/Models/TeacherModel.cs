using System.ComponentModel.DataAnnotations;

namespace MvcNewProject.Models
{
    public class TeacherModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
       
        public DateTime DateOfBirth { get; set; }

        public List<CourseModel>? Courses { get; set; }
    }
}
