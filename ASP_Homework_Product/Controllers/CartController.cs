using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace ASP_Homework_Product.Controllers
{
    public class CartController : Controller
    {

        private readonly ProductsRepository productRepository;
        public CartController()
        {
            productRepository = new ProductsRepository();
        }

        public ActionResult Index()
        {
            var cart = CartsRepository.TryGetByUserId(Constants.UserId);
            return View(cart);
        }

        public IActionResult Add(int productId)
        {
            var product = productRepository.TryGetById(productId);
            CartsRepository.Add(product, Constants.UserId);
            return RedirectToAction("Index");
        }
    }
}
