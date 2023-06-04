using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework;

namespace Home13.Tests
{
    [TestFixture]
    public class BaseTest
    {
        protected WebDriver driver;
        protected ApplicationHelper app;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            app = new ApplicationHelper(driver);
            //Неявное ожидание
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
