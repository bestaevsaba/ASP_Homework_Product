﻿using System;
using System.Collections.Generic;
using System.Linq;
using ASP_Homework_Product.Models;

namespace ASP_Homework_Product.Models
{
    public class Cart
    {
        public Guid Id;
        public string UserId {  get; set; }
        public List<CartItem> Items { get; set;}
        public decimal Cost
        {
            get 
            {
                return Items.Sum(x => x.Cost);
            }
        }
    }
}
