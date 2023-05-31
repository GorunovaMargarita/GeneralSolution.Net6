using NuGet.Frameworks;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Home12.HerokuApp.Test
{
    [TestFixture]
    public class Dropdown : BaseTest
    {
        
        [Test]
        public void CheckAllElements()
        {
            GoToDropdown();
            var optionList = GetValuesFromList(dropdown);

            Assert.IsTrue(optionList.Contains("Option 1") && optionList.Contains("Option 2"));
        }
        [Test]
        public void SelectOption1([Values("Option 1", "Option 2")] string value)
        {
            GoToDropdown();
            SelectValueFromList(dropdown, value);

            Assert.IsTrue(GetSelectedOption(dropdown).Equals(value));
        }

        By dropdown = By.Id("dropdown");

        private void GoToDropdown()
        {
            IWebElement dropDownLink = driver.FindElement(By.LinkText("Dropdown"));
            dropDownLink.Click();
        }
        public void SelectValueFromList(By locator, String value)
        {
                SelectElement select = new SelectElement(driver.FindElement(locator));
                if (!select.SelectedOption.Text.Equals(value))
                {
                    select.SelectByText(value);
                }
        }
        public List<string> GetValuesFromList(By locator)
        {
            SelectElement select = new SelectElement(driver.FindElement(locator));
            var listOptions = new List<string>();
            foreach(var element in select.Options)
            {
                listOptions.Add(element.Text);
            }
            return listOptions;
        }
        public string GetSelectedOption(By locator)
        {
            SelectElement select = new SelectElement(driver.FindElement(locator));
            return select.SelectedOption.Text;
        }
    }
}