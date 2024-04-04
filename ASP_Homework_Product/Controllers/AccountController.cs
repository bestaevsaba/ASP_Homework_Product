using ASP_Homework_Product.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP_Homework_Product.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Login login) 
        {
            if (ModelState.IsValid) return RedirectToAction("Index", "Home"); else return RedirectToAction("Login");

        }
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Register register)
        {
            if (ModelState.IsValid) return RedirectToAction("Index", "Home"); else return RedirectToAction("Register");
        }
    }
}
