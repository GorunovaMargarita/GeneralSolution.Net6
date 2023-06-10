using OpenQA.Selenium;

namespace Hometask14.Pages
{
    public class DynamicControls : BasePage
    {
        private string url = "http://the-internet.herokuapp.com/dynamic_controls";
        public By CheckBox = By.CssSelector("input[type=checkbox]");
        public By TextInput = By.CssSelector("input[type=text]");
        public By EnableTextInput = By.CssSelector("button[onclick='swapInput()']");
        public By RemoveCheckBoxButton = By.CssSelector("button[onclick='swapCheckbox()']");
        public By TextInputEnabled = By.XPath("//p[contains(text(),'enabled!')]");
        public By CheckBoxGone = By.XPath("//p[contains(text(),'gone!')]");

        public override DynamicControls Open()
        {
            driver.Navigate().GoToUrl(url);
            return this;
        }
    }
}
