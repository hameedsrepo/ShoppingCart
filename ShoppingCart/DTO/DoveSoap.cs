using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.DTO
{
    public class DoveSoap : IItem
    {
        public float price { get => price; set => price = 39.99f; }
        public int quantity { get => quantity; set => quantity = 1; }

        public DoveSoap(float priceIn = 39.99f, int quantityIn = 1)
        {
            price = priceIn;
            quantity = quantityIn;
        }
    }
}
