using Microsoft.AspNetCore.Mvc;

namespace ASP_Homework_Product.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly IProductsRepository productRepository;
        private readonly ICartsRepository cartsRepository;

        public HomeController(IProductsRepository productRepository, ICartsRepository cartsRepository)
        {
            this.productRepository = productRepository;
            this.cartsRepository = cartsRepository;
        }

        public IActionResult Index()
        {
            var products = productRepository.GetProducts();
            return View(products);
        }
    }
}
