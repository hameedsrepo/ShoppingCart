using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.DTO
{
    public class AxeDeo : IItem
    {
        public float price { get => price; set => price = 99.99f; }
        public int quantity { get => quantity; set => quantity = 1; }

        public AxeDeo(float priceIn = 39.99f, int quantityIn = 1)
        {
            price = priceIn;
            quantity = quantityIn;
        }
    }
}
