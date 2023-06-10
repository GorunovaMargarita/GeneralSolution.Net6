using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace Hometask14
{
    public class Browser
    {
        private static Browser? instance = null;
        private IWebDriver driver;
        public IWebDriver Driver { get { return driver; } }

        public static Browser Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Browser();
                }

                return instance;
            }
        }
        private Browser()
        {
            //choose browser
            var isHeadless = bool.Parse(GetRunSetting("Headless"));
            var wait = int.Parse(GetRunSetting("ImplicityWait"));

            if (GetRunSetting("BrowserType").Equals("Chrome"))
            {
                ChromeOptions options = new ChromeOptions();
                options.AddArgument("--start-maximized");
                options.AddUserProfilePreference("download.default_directory", TestContext.Parameters.Get("DownloadFolder"));

                if (isHeadless)
                {
                    options.AddArgument("--headless");
                }

                driver = new ChromeDriver(options);
            }

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(wait);
            driver.Manage().Window.Maximize();
        }
        public void CloseBrowser()
        {
            driver?.Dispose();
            instance = null;
        }

        public void NavigateToUrl(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void AcceptAllert()
        {
            driver.SwitchTo().Alert().Accept();
        }

        public void DismissAlert()
        {
            driver.SwitchTo().Alert().Dismiss();
        }

        public void SwitchToFrame(string id)
        {
            driver.SwitchTo().Frame(id);
        }

        public void SwitchToDefault()
        {
            driver.SwitchTo().DefaultContent();
        }

        public object ExecuteScript(string scipt, object? argument = null)
        {
            try
            {

                return ((IJavaScriptExecutor)driver).ExecuteScript(scipt, argument);
            }
            catch (Exception)
            {
                return null;
            }
        }
        private static string GetRunSetting(string settingName)
        {
            return TestContext.Parameters.Get(settingName) ?? throw new InvalidOperationException($"{settingName} not found in runsettings file.");
        }
    }
}
