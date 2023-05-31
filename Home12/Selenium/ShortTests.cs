using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home12.Selenium
{
    public class ShortTests
    {
        WebDriver driver;
        [SetUp] 
        public void Setup()
        {
            driver = new ChromeDriver();
            //Неявное ожидание
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }
        [Test]
        public void OpenWindow()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/");
        }
        [Test]
        public void OpenYa()
        {
            driver.Manage().Window.FullScreen();
            driver.Navigate().GoToUrl("https://ya.ru/");
        }
        [TearDown] 
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
