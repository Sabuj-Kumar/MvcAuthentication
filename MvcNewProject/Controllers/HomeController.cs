using Microsoft.AspNetCore.Mvc;
using MvcNewProject.Data;
using MvcNewProject.Models;
using System.Diagnostics;

namespace MvcNewProject.Controllers
{

    public class HomeController : Controller
    {
        private readonly ApplicationDBContext _db;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}