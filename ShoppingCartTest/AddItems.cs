using ShoppingCart.DTO;
using ShoppingCart;
using System;
using Xunit;

namespace ShoppingCartTest
{
    public class AddItems
    {
        //Assign, Act, Assert structure & RGR Pattern

        [Fact]
        //AC0
        public void AddSingleDoveSoap()
        {
            Cart cart = new Cart();
            DoveSoap doveSoap = new DoveSoap();
            cart.Add(doveSoap);
            Assert.Equal("39.99", cart.ComputeTotalNoTax());
            Assert.Equal(1, cart.cartQuantity);
        }

        [Fact]
        //AC1
        public void AddMultipleItems() 
        {
            Cart cart = new Cart();
            DoveSoap doveSoap_3 = new DoveSoap(quantityIn:3);
            cart.Add(doveSoap_3);
            DoveSoap doveSoap_5 = new DoveSoap(quantityIn:5);
            cart.Add(doveSoap_5);
            Assert.Equal("319.92", cart.ComputeTotalNoTax()); 
            Assert.Equal(8, cart.cartQuantity);
        }

        [Fact]
        //AC2
        public void CalculateTax() 
        {
            Cart cart = new Cart();
            cart.setTaxRate(12.5f);
            DoveSoap doveSoap = new DoveSoap(quantityIn:2);
            cart.Add(doveSoap);
            AxeDeo axeDeo = new AxeDeo(quantityIn: 2);
            cart.Add(axeDeo);
            Assert.Equal("35.00", cart.ComputeTaxOnly()); 
            Assert.Equal("314.96", cart.ComputeTotalWithTax());
        }
    }
}
