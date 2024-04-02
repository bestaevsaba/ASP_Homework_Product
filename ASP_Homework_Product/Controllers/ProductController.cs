using System.ComponentModel;

namespace ASP_Homework_Product.Controllers
{
    public class ProductController : Container
    {

        private readonly ProductRepository productRepository;
        public ProductController()
        {
            productRepository = new ProductRepository();
        }

        public string Index(int id)
        {
            var product = productRepository.TryGetById(id);
            if(product == null) { return $"id = {id} не существует"; }
            return $"{product}\n{product.Description}";
        }
    }
}
