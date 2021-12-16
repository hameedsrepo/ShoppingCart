using ShoppingCart.DTO;
using System;

namespace ShoppingCart
{
    public class Cart
    {
        public float total = 0f;
        public float taxRate = 12.9f;

        public void Add(IItem item)
        {
            throw new NotImplementedException();
        }
    }
}
