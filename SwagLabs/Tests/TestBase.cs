using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SwagLabs.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwagLabs.Tests
{
    internal class TestBase
    {
        protected WebDriver driver;
        protected LoginPage loginPage;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            //Неявное ожидание
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            loginPage = new LoginPage(driver);
        }
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
