using Home13.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home13.Pages
{
    public class CartPage : BasePage
    {
        private const string Url = "https://www.saucedemo.com/cart.html";

        private By Title = By.CssSelector("span.title");
        private By ContinueButton = By.Id("continue-shopping");
        private By CheckoutButton = By.Id("checkout");
        private By RemoveButton = By.Id("remove-sauce-labs-backpack");
        private By ProductItem = By.CssSelector("div.cart_item");
        private By Name = By.CssSelector("div.inventory_item_name");
        private By Quantity = By.ClassName("cart_quantity");
        private By Price = By.ClassName("inventory_item_price");
        private By Desc = By.ClassName("inventory_item_desc");

        public CartPage(WebDriver driver) : base(driver)
        {
            WaitHelper.WaitElement(driver, Title);
        }

        public override CartPage Open()
        {
            driver.Navigate().GoToUrl(Url);
            return this;
        }
        public InventoryPage BackToInventoryPage()
        {
            driver.FindElement(ContinueButton).Click();
            return new InventoryPage(driver);
        }
        public CheckOutPage GoToCheckoutPage()
        {
            driver.FindElement(CheckoutButton).Click();
            return new CheckOutPage(driver);
        }
        public List<Product> GetProductList()
        {
            List<Product> products = new List<Product>();
            var productElements = driver.FindElements(ProductItem);
            foreach (var productElement in productElements)
            {
                products.Add(new Product(productElement.FindElement(Name).Text, 
                                         productElement.FindElement(Desc).Text, 
                                         productElement.FindElement(Price).Text, 
                                         productElement.FindElement(Quantity).Text));
            }
            return products;
        }
        public CartPage RemoveProduct()
        {
            driver.FindElement(RemoveButton).Click();
            return this;
        }
     
    }
}
