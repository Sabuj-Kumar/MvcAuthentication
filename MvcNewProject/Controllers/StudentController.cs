﻿using Microsoft.AspNetCore.Mvc;
using MvcNewProject.Data;

namespace MvcNewProject.Controllers
{
    
    public class StudentController : Controller
    {
        private readonly ApplicationDBContext _db;
        public IActionResult Index()
        {
            return View();
        }
    }
}
