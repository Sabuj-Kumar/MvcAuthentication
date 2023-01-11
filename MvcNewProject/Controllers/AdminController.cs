using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MvcNewProject.Data;
using MvcNewProject.Models;

namespace MvcNewProject.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDBContext _db;
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> SignInManager;
        public AdminController(ApplicationDBContext db, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _db = db;
            this.userManager = userManager;
            this.SignInManager = signInManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login() {

            ViewData["Title"] = "Log In Page";
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
              
                var result = await SignInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe,false);

                if (result.Succeeded)
                {
                    return View();
                }
                ModelState.AddModelError(string.Empty, "Invalid User"); 
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Logout() {

            await SignInManager.SignOutAsync();

            return RedirectToAction("Registration", "Admin");
        }
        public IActionResult Registration() {

            ViewData["Title"] = "Registration Page";
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Registration(AdminRegistrationModel obj)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser()
                {
                    UserName = obj.Name,
                    Email = obj.Email,
                };

                var result = await userManager.CreateAsync(user, obj.Password);

                if (result.Succeeded)
                {
                    await SignInManager.SignInAsync(user, false);

                    return RedirectToAction("Login");
                }

                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
            }
            return View();
        }
    }
}
