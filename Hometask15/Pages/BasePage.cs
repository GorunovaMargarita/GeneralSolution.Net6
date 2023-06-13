using OpenQA.Selenium;


namespace Hometask15.Pages
{
    public abstract class BasePage
    {
        protected IWebDriver driver;

        public BasePage()
        {
            this.driver = Browser.Instance.Driver;
        }

        public abstract BasePage Open();
    }
}
