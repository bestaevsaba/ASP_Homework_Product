using ASP_Homework_Product.Models;

namespace ASP_Homework_Product
{
    public interface ICartsRepository
    {
        void Add(Product product, string userId);
        Cart TryGetByUserId(string userId);
    }
}