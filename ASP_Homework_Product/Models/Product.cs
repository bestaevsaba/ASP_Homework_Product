using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Homework_Product.Models
{
    public class Product
    {
        private  static int instanceCounter = 0;
        public int Id { get; }
        public string Name { get; }
        public decimal Cost { get; }
        public string Description { get; }

        public Product(string name, decimal cost, string description)
        {
            Description = description;
            Name = name;
            Cost = cost;
            Id = instanceCounter++;
        }

        public override string ToString()
        {
            return $"{Id}\n{Name}\n{Cost}";
        }
    }
}
