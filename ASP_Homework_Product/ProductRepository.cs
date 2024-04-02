using ASP_Homework_Product.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Homework_Product
{
    public class ProductRepository
    {
       public  List<Product> products = new List<Product>()
        {
            new Product("Palit GeForce RTX 4070 Dual OC", 65000),
            new Product("ASUS GeForce RTX 4060 ProArt OC", 43000),
            new Product("GIGABYTE GeForce RTX 4070 Ti WINDFORCE OC", 86000),
        };

         public List<Product> GetProducts() { return products; }      
    }
}
