using Microsoft.Build.Framework;

namespace MvcNewProject.Models
{
    public class CourseModel
    {
        
        public int Id { get; set; }
        [Required]
        public string? CourseName { get; set; }
        [Required]
        public int CourseCode { get; set; }
        [Required]
        public int CourseCredit { get; set; } 
    }
}
