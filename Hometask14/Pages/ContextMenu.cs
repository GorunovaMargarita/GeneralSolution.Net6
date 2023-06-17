using OpenQA.Selenium;


namespace Hometask14.Pages
{
    public class ContextMenu : BasePage
    {
        private static string url = "http://the-internet.herokuapp.com/context_menu";
        public By Box =  By.Id("hot-spot");

        public override ContextMenu Open()
        {
            driver.Navigate().GoToUrl(url);
            return this;
        }
    }
}
