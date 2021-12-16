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
            Assert.Equal(cart.total, doveSoap.price);
        }

        [Fact]
        public void AddMultipleItems() { }

        [Fact]
        public void CalculateTax() { }
    }
}
