﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASP_Homework_Product.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Orders()
        {
            return View();
        }
        public IActionResult Users()
        {
            return View();
        }
        public IActionResult Roles()
        {
            return View();
        }
        public IActionResult Products()
        {
            return View();
        }
    }
}
