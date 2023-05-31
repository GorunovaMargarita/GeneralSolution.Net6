using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home12.HerokuApp.Test
{
    [TestFixture]
    public class BaseTest
    {
        protected WebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            //Неявное ожидание
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/");
        }
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
