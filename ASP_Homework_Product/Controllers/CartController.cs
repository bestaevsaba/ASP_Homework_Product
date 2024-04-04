using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace ASP_Homework_Product.Controllers
{
    public class CartController : Controller
    {

        private readonly ProductsRepository productRepository;
        private readonly CartsRepository cartsRepository;
        public CartController(ProductsRepository productRepository, CartsRepository cartsRepository)
        {
            this.productRepository = productRepository;
            this.cartsRepository = cartsRepository;
        }
       
        public ActionResult Index()
        {
            var cart = cartsRepository.TryGetByUserId(Constants.UserId);
            return View(cart);
        }

        public IActionResult Add(int productId)
        {
            var product = productRepository.TryGetById(productId);
            cartsRepository.Add(product, Constants.UserId);
            return RedirectToAction("Index");
        }
    }
}
