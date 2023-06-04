using Home13.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home13.Pages
{
    public class InventoryPage : BasePage
    {
        private const string Url = "https://www.saucedemo.com/inventory.html";
        private By ShoppingCartLink = By.ClassName("shopping_cart_link");
        private By ProductItem = By.CssSelector("div.inventory_item");
        private By Name = By.CssSelector("div.inventory_item_name");
        private By Quantity = By.ClassName("cart_quantity");
        private By Price = By.ClassName("inventory_item_price");
        private By Desc = By.ClassName("inventory_item_desc");
        private By AddToCartButton = By.XPath("//*[text()='Add to cart']");
        private By AddedProduct = By.XPath("//*[text()='Remove']/../../.."); 
        private By NotAddedProduct = By.XPath("//*[text()='Add to cart']/../../..");
        public InventoryPage(WebDriver driver) : base(driver)
        {
            WaitHelper.WaitElement(driver, ShoppingCartLink);
        }
        public override InventoryPage Open()
        {
            driver.Navigate().GoToUrl(Url);
            return this;
        }
        public InventoryPage CheckPorductsLoaded()
        {
            Assert.IsTrue(driver.FindElements(ProductItem).Count() > 0);
            return this;
        }
        public InventoryPage AddRandomProduct() 
        {
            var t = driver.FindElements(NotAddedProduct);
                   t.First()
                   .FindElement(AddToCartButton)
                   .Click();
            return this;
        }
        public List<Product> GetAddedProduct()
        {
            List<Product> products = new List<Product>();
            var productElements = driver.FindElements(AddedProduct);
            foreach (var productElement in productElements)
            {
                products.Add(new Product(productElement.FindElement(Name).Text,
                                         productElement.FindElement(Desc).Text,
                                         productElement.FindElement(Price).Text,
                                         "1"));
            }
            return products;
        }
    }
}
