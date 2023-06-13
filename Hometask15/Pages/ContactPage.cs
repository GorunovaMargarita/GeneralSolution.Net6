using FluentAssertions;
using Hometask15.Elements;
using Hometask15.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask15.Pages
{
    public class ContactPage : BasePage
    {
        private const string Url = "https://ooomtsdi-dev-ed.develop.lightning.force.com/lightning/o/Contact/list?filterName=Recent";
        Button newContactButton = new(By.XPath("//div[@title='New']"));
        Button contactsButton = new(By.XPath("//span[text()='Contacts']"));
        Input searchField = new(By.XPath("//Input[@name= 'Contact-search-input']"));

        public override ContactPage Open()
        {
            Browser.Instance.NavigateToUrl(Url);
            return this;
        }

        public NewContactModal OpenNewContactModal()
        {
            newContactButton.GetElement().Click();
            return new NewContactModal();
        }

        public ContactPage ReloadContacts()
        {
            driver.Navigate().Refresh();
            WaitHelper.WaitPageLoaded(driver);
            contactsButton.ClickElementViaJs();
            return this;
        }

        public ContactPage CheckContactWithAttExist(string attribute)
        {
            searchField.EnterText(attribute);
            driver.FindElements(By.XPath($"//*[text()='{attribute}']")).Count().Should().BeGreaterThan(0);
            return this;
        }
    }
}
