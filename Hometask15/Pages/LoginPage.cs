using Hometask15.Elements;
using Model;
using NUnit.Allure.Attributes;
using OpenQA.Selenium;


namespace Hometask15.Pages
{
    public class LoginPage : BasePage
    {
        private string url = "https://ooomtsdi-dev-ed.develop.my.salesforce.com/";

        private Input userNameInput = new(By.XPath("//input[@name='username']"));
        private Input passwordInput = new(By.XPath("//input[@name='pw']"));
        private Button loginButton = new(By.Id("Login"));

        public override LoginPage Open()
        {
            Browser.Instance.NavigateToUrl(url);
            return this;
        }
        [AllureStep]
        public LoginPage Login(User user)
        {
            userNameInput.GetElement().SendKeys(user.Name);
            passwordInput.GetElement().SendKeys(user.Password);
            loginButton.GetElement().Click();

            return this;
        }
    }
}
