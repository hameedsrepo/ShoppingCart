using ShoppingCart.DTO;
using System;

namespace ShoppingCart
{
    public class Cart
    {
        public float totalPrice = 0f;
        private float taxRate = 0f;
        public int cartQuantity = 0;

        public float setTaxRate(float taxRate)
        {
            if (taxRate > 0 && taxRate < 100) //technically could be outside of the bounds....
            {
                this.taxRate = taxRate / 100 + 1;
                return this.taxRate;
            }
            else
            {
                throw new Exception($"invalid tax rate value of: {taxRate}%");
            }
        }

        public void Add(IItem item)
        {
            totalPrice += item.price * item.quantity;
            cartQuantity += item.quantity;
        }

        public string ComputeTotalNoTax()
        {
            return roundPrice(totalPrice);
        }

        public string ComputeTotalWithTax()
        {
            return roundPrice(taxRate * totalPrice);
        }

        public string ComputeTaxOnly()
        {
            return roundPrice((taxRate - 1) * totalPrice);
        }

        private string roundPrice(float input)
        {
            string retVal = input.ToString("F");
            //found a bug in C#....xx.995%1 is not equivalent to 0.995 as it should (and similar values)
            float modulo = input % 1;
            if (modulo >= 0.995f)
            {
                retVal = (float.Parse(retVal) + 0.01).ToString("F");
            }
            return retVal;
        }
    }
}
