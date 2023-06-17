using Hometask14.Pages;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;


namespace Hometask14.Tests
{
    public class ContextMenuTests : TestBase
    {
        [Test]
        public void AlertTest()
        {
            var page = new ContextMenu().Open();

            var action = new Actions(Browser.Instance.Driver);
            action.ContextClick(Browser.Instance.Driver.FindElement(page.Box)).Perform();

            Browser.Instance.AcceptAllert();
        }
    }
}
