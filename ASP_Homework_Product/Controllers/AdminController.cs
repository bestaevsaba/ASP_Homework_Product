using ASP_Homework_Product.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ASP_Homework_Product.Controllers
{
    public class AdminController : Controller
    {
        private readonly IProductsRepository productsRepository;
        private readonly IOrdersRepository ordersRepository;
        public AdminController(IProductsRepository productsRepository, IOrdersRepository ordersRepository)
        {
            this.productsRepository = productsRepository;
            this.ordersRepository = ordersRepository;
        }

        public IActionResult Orders()
        {
            var orders = ordersRepository.GetAll();
            return View(orders);
        }

        public IActionResult OrderDetails(Guid orderId)
        {
            var order = ordersRepository.TryGetById(orderId);
            return View(order);
        }
        public IActionResult UpdateOrderStatus(Guid orderId, OrderStatus status)
        {
            ordersRepository.UpdateStatus(orderId, status);
            return RedirectToAction("Orders");
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
            var products = productsRepository.GetProducts();
            return View(products);
        }
        public IActionResult AddProduct() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            if(!ModelState.IsValid) return View(product);
            productsRepository.Add(product);
            return RedirectToAction("Products");
        }

        public IActionResult EditProduct(int productId)
        {
            var product = productsRepository.TryGetById(productId);
            return View(product);
        }
        [HttpPost]
        public IActionResult EditProduct(Product product)
        {
            if (!ModelState.IsValid) return View(product);
            productsRepository.Update(product);
            return RedirectToAction("Products");
        }
    }
}
