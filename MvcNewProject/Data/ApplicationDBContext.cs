using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MvcNewProject.Models;

namespace MvcNewProject.Data
{
    public class ApplicationDBContext : IdentityDbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
        public DbSet<AdminModel> AdminModels { get; set; }
        public DbSet<CourseModel> CourseModels { get; set; }
        public DbSet<StudentModel> StudentModels { get; set; }
        public DbSet<TeacherModel> TeacherModels { get; set; }
        public DbSet<AdminRegistrationModel> AdminRegistrationModels { get; set; }
       
    }
}
