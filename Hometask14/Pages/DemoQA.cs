using Hometask14.Helpers;
using OpenQA.Selenium;



namespace Hometask14.Pages
{
    public class DemoQA : BasePage
    {
        private static string url = "https://demoqa.com/upload-download";
        public By DownloadButton = By.Id("downloadButton");

        public override DemoQA Open()
        {
            driver.Navigate().GoToUrl(url);
            WaitHelper.WaitPageLoaded(Browser.Instance.Driver, 60);
            return this;
        }

        public DemoQA DownloadFile()
        {
            driver.FindElement(DownloadButton).Click();
            return this;
        }
    }
}
