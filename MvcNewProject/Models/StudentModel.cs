using Microsoft.Build.Framework;

namespace MvcNewProject.Models
{
    public class StudentModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string BatchName { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string DepartmentName { get; set; }
        [Required]
        public string Semester { get; set; } 
        public DateTime DateOfBirth { get; set; }

        public List<CourseModel>? Courses { get; set; }

        public double Result { get; set; }

    }
}
