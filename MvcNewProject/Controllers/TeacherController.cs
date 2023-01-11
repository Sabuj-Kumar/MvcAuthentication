using Microsoft.AspNetCore.Mvc;
using MvcNewProject.Data;

namespace MvcNewProject.Controllers
{
   
    public class TeacherController : Controller
    {
        private readonly ApplicationDBContext _db;
        public IActionResult Index()
        {
            return View();
        }
    }
}
