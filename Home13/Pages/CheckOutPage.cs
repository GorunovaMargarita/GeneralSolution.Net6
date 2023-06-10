using Home13.Helpers;
using OpenQA.Selenium;
using Faker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using FluentAssertions;

namespace Home13.Pages
{
    public class CheckOutPage : BasePage
    {
        private const string Url = "https://www.saucedemo.com/checkout-step-one.html";
        private By Title = By.CssSelector("span.title");
        private By CancelButton = By.Id("cancel");
        private By ContinueButton = By.Id("continue");
        private By FirstNameInput = By.Id("first-name");
        private By LastNameInput = By.Id("last-name");
        private By PostalCodeInput = By.Id("postal-code");
        private By ErrorButton = By.XPath("//*[@class = 'error-button']/..");
        private By OrderSuccessMessage = By.ClassName("complete-header");
        private By FinishButton = By.Id("finish");
        private By PriveWithoutTax = By.ClassName("summary_subtotal_label");
        private By Tax = By.ClassName("summary_tax_label");
        private By TotalPrice = By.ClassName("summary_info_label.summary_total_label");
        private By BackToProductsButton = By.Id("back-to-products");
        public CheckOutPage(WebDriver driver) : base(driver)
        {
            WaitHelper.WaitElement(driver, Title);
        }

        public override CheckOutPage Open()
        {
            driver.Navigate().GoToUrl(Url);
            return this;
        }
        public CheckOutPage FillCheckoutForm()
        {
            driver.FindElement(FirstNameInput).SendKeys(NameFaker.Name());
            driver.FindElement(LastNameInput).SendKeys(NameFaker.LastName());
            driver.FindElement(PostalCodeInput).SendKeys(NumberFaker.Number().ToString());
            return this;
        }
        public CheckOutPage TryFillCheckoutForm(string name, string lastName, string postalCode)
        {
            driver.FindElement(FirstNameInput).SendKeys(name);
            driver.FindElement(LastNameInput).SendKeys(lastName);
            driver.FindElement(PostalCodeInput).SendKeys(postalCode);
            ContinueCheckout();
            return this;
        }
        public CheckOutPage VerifyErrorMessage(string errorMustBe)
        {
            driver.FindElement(ErrorButton).Text.Should().Be(errorMustBe);
            return this;
        }
        public CheckOutPage ContinueCheckout()
        {
            driver.FindElement(ContinueButton).Click();
            return this;
        }
        public InventoryPage CancelOrder()
        {
            driver.FindElement(CancelButton).Click();
            return new InventoryPage(driver);
        }
        public CheckOutPage FinishOrder()
        {
            driver.FindElement(FinishButton).Click();
            return new CheckOutPage(driver);
        }
        public CheckOutPage VerifySuccessMessage()
        {
            Assert.IsTrue(driver.FindElement(OrderSuccessMessage).Text.Equals(Constants.CheckoutMessages.successText));
            return this;
        }
    }
}
