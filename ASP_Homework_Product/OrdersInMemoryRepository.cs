using ASP_Homework_Product.Models;
using System.Collections.Generic;

namespace ASP_Homework_Product
{
    public class OrdersInMemoryRepository : IOrdersRepository
    {
        private List<Order> orders = new List<Order>();

        public void Add(Order order)
        {
            orders.Add(order);
        }
    }
}
