using Home13.Pages;
using NUnit.Framework;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home13.Tests
{
    [TestFixture]
    public class CreateOrder : BaseTest
    {
        [Test]
        public void CreateOrder_OneProductAsStandartUser_Ok()
        {
            app.InitOrder(TestData.TestUsers.Standart);

            app.AddProductsToCart(1);

            Product addedProduct = new InventoryPage(driver).GetAddedProduct().First();

            var cartPage = new CartPage(driver).Open();
            Product productInCart = cartPage.GetProductList().First();
            productInCart.Should().BeEquivalentTo(addedProduct);

            app.FinishProductOrder();
        }
        [Test]
        public void CreateOrder_TwoProductsAsStandartUser_Ok()
        {
            app.InitOrder(TestData.TestUsers.Standart);

            app.AddProductsToCart(2);

            Product addedProduct = new InventoryPage(driver).GetAddedProduct().First();

            var cartPage = new CartPage(driver).Open();
            Product productInCart = cartPage.GetProductList().First();
            productInCart.Should().BeEquivalentTo(addedProduct);

            app.FinishProductOrder();
        }
        [Test]
        public void CreateOrder_ExitFromCartAndReturn_Ok()
        {
            app.InitOrder(TestData.TestUsers.Standart);

            app.AddProductsToCart(1);

            Product addedProduct = new InventoryPage(driver).GetAddedProduct().First();

            var cartPage = new CartPage(driver).Open();
            Product productInCart = cartPage.GetProductList().First();
            productInCart.Should().BeEquivalentTo(addedProduct);

            cartPage.BackToInventoryPage();

            cartPage.Open();

            productInCart = cartPage.GetProductList().First();
            productInCart.Should().BeEquivalentTo(addedProduct);
        }
        [Test]
        public void CreateOrder_RemoveProductFromCart_Ok()
        {
            app.InitOrder(TestData.TestUsers.Standart);

            app.AddProductsToCart(1);

            var cartPage = new CartPage(driver).Open();
            
            cartPage.RemoveProduct();

            cartPage.BackToInventoryPage();

            cartPage.Open();

            cartPage.GetProductList().Count().Should().Be(0);
        }

        [Test]
        public void CreateOrder_FirtsNameNotSet_Error()
        {
            app.InitOrder(TestData.TestUsers.Standart);

            app.AddProductsToCart(1);

            var cartPage = new CartPage(driver).Open();

            cartPage.GoToCheckoutPage()
                    .TryFillCheckoutForm("", Faker.NameFaker.LastName(), Faker.NumberFaker.Number().ToString())   
                    .VerifyErrorMessage(Constants.CheckoutMessages.firstNameNotSet);
        }
    }
}
