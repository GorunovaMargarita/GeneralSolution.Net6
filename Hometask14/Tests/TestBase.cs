using NUnit.Framework;
using OpenQA.Selenium;

namespace Hometask14.Tests
{
    public class TestBase
    {
        protected IWebDriver driver = Browser.Instance.Driver;
        [SetUp]
        public void Setup()
        {
        }
        [TearDown]
        public void TearDown()
        {
            Browser.Instance.CloseBrowser();
        }
    }
}
