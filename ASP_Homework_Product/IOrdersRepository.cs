﻿using ASP_Homework_Product.Models;

namespace ASP_Homework_Product
{
    public interface IOrdersRepository
    {
        void Add(Cart cart);
    }
}