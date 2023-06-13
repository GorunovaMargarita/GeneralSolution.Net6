using NUnit.Framework;
using OpenQA.Selenium;

namespace Hometask15.Tests
{
    public class TestBase
    {
        protected IWebDriver driver = Browser.Instance.Driver;
        protected ApplicationHelper appHelper = new ApplicationHelper(Browser.Instance.Driver);
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
