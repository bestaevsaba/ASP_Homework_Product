using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Homework_Product.Models
{
    public class Product
    {
        public int Id { get; }
        public string Name { get; }
        public decimal Cost { get; }
        public string Description { get; }

        public Product(string name, decimal cost)
        {
            Name = name;
            Cost = cost;

        }

        public override string ToString()
        {
            return $"{Id}\n{Name}\n{Cost}\n";
        }
    }
}
