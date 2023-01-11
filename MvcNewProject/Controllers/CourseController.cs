using Microsoft.AspNetCore.Mvc;
using MvcNewProject.Data;

namespace MvcNewProject.Controllers
{
    public class CourseController : Controller
    {
        private readonly ApplicationDBContext _db;
        public IActionResult Index()
        {
            return View();
        }
    }
}
