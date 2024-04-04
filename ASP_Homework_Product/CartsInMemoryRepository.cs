using ASP_Homework_Product.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ASP_Homework_Product
{
    public class CartsInMemoryRepository : ICartsRepository
    {
        private List<Cart> carts = new List<Cart>();

        public Cart TryGetByUserId(string userId)
        {
            return carts.FirstOrDefault(x => x.UserId == userId);
        }

        public void Add(Product product, string userId)
        {
            var exisitingCart = TryGetByUserId(userId);
            if (exisitingCart == null)
            {
                var newCart = new Cart
                {
                    Id = Guid.NewGuid(),
                    UserId = userId,
                    Items = new List<CartItem>
                    {
                        new CartItem
                        {
                            Id = Guid.NewGuid(),
                            Amount = 1,
                            Product = product,
                        }
                    }
                };

                carts.Add(newCart);
            }
            else
            {
                var existingCartItem = exisitingCart.Items.FirstOrDefault(x => x.Product.Id == product.Id);
                if (existingCartItem != null)
                {
                    existingCartItem.Amount += 1;
                }
                else
                {
                    exisitingCart.Items.Add(new CartItem
                    {
                        Id = Guid.NewGuid(),
                        Amount = 1,
                        Product = product,
                    });
                }
            }
        }

        public void DecreaseAmount(int productId, string userId)
        {
            var exisitingCart = TryGetByUserId(userId);            
            var existingCartItem = exisitingCart?.Items?.FirstOrDefault(x => x.Product.Id == productId);
            if (existingCartItem == null)
            {
                    return;
            }

            existingCartItem.Amount -= 1;

            if (existingCartItem.Amount == 0) 
            {
                exisitingCart.Items.Remove(existingCartItem);
            }
        }

        public void Clear(string userId)
        {
            var exisitingCart = TryGetByUserId(userId);
            carts.Remove(exisitingCart);
        }
    }
}
