using ShoppingCart.DTO;
using ShoppingCart;
using System;
using Xunit;

namespace ShoppingCartTest
{
    public class AddItems
    {
        [Fact]
        public void AddSingleDoveSoap()
        {
            Cart cart = new Cart();
            DoveSoap doveSoap = new DoveSoap();
            cart.Add(doveSoap);
            Assert.Equal(doveSoap.price, cart.totalPrice);
        }

        [Fact]
        public void AddMultipleItems() 
        {
            Cart cart = new Cart();
            DoveSoap doveSoap_3 = new DoveSoap(quantityIn:3);
            cart.Add(doveSoap_3);
            DoveSoap doveSoap_5 = new DoveSoap(quantityIn:5);
            cart.Add(doveSoap_5);
            Assert.Equal(doveSoap_5.price * 8, cart.totalPrice); //319.92
            Assert.Equal(8, cart.totalQuantity);
        }

        [Fact]
        public void CalculateTax() 
        {
            Cart cart = new Cart();
            DoveSoap doveSoap = new DoveSoap(quantityIn:2);
            cart.Add(doveSoap);
            AxeDeo axeDeo = new AxeDeo(quantityIn: 2);
            cart.Add(axeDeo);
            Assert.Equal(35, cart.ComputeTotalWithTax() - cart.totalPrice);
            Assert.Equal(314.96, cart.totalPrice);
        }
    }
}
