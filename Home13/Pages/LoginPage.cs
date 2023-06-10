using Model;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Home13.Pages
{
    internal class LoginPage : BasePage
    {
        private const string Url = "https://www.saucedemo.com/";

        private By UserNameInput = By.Id("user-name");
        private By PasswordInput = By.Id("password");
        private By ErrorMessage = By.CssSelector(".error-message-container.error");
        private By LoginButton = By.Id("login-button"); 

        public LoginPage(WebDriver driver) : base(driver)
        {
        }

        public InventoryPage Login (User user)
        {
            TryToLogin (user);
            return new InventoryPage(driver);
        }
        public LoginPage TryToLogin(User user)
        {
            driver.FindElement(UserNameInput).SendKeys(user.Name);
            driver.FindElement(PasswordInput).SendKeys(user.Password);
            driver.FindElement(LoginButton).Click();
            return this;
        }

        public override LoginPage Open()
        {
            driver.Navigate().GoToUrl(Url);
            return this;
        }
        public LoginPage VerifyErrorMessage(string errorText)
        {
            //check display status for ErrorMessage 
            Assert.IsTrue(Equals(driver.FindElement(ErrorMessage).Text, errorText));
            return this;
        }
    }
}
