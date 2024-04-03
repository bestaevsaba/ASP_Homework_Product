﻿using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace ASP_Homework_Product.Controllers
{
    public class ProductController : Controller
    {

        private readonly ProductsRepository productRepository;
        public ProductController()
        {
            productRepository = new ProductsRepository();
        }

        public IActionResult Index(int id)
        {
            var product = productRepository.TryGetById(id);
            return View(product);
        }
    }
}
