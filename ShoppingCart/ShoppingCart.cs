using ShoppingCart.DTO;
using System;

namespace ShoppingCart
{
    public class Cart
    {
        public float totalPrice = 0f;
        public float taxRate = 12.9f;
        public int totalQuantity = 0;

        public void Add(IItem item)
        {
            throw new NotImplementedException();
        }

        public float ComputeTotalWithTax()
        {
            throw new NotImplementedException();
        }
    }
}
