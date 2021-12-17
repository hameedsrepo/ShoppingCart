﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.DTO
{
    public class AxeDeo : IItem
    {
        public float price { get; set; }
        public int quantity { get; set; }

        public AxeDeo(float priceIn = 99.99f, int quantityIn = 1)
        {
            price = priceIn;
            quantity = quantityIn;
        }
    }
}
