using NuGet.Frameworks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home12.HerokuApp.Test
{
    [TestFixture]
    public class Checkboxes : BaseTest
    {
        
        
        [Test]
        public void CheckFirstBox()
        {
            GoToCheckboxes();
            List<IWebElement> checkBoxes = driver.FindElements(By.CssSelector("[type = checkbox]")).ToList();
            var firstCheckbox = checkBoxes[0];

            SetCheckBoxState(firstCheckbox, true);

            Assert.True(GetCheckBoxState(firstCheckbox));
        }
        [Test]
        public void UcheckSecondBox()
        {
            GoToCheckboxes();
            List<IWebElement> checkBoxes = driver.FindElements(By.CssSelector("[type = checkbox]")).ToList();
            var secondCheckBox = checkBoxes[1];

            Assert.True(GetCheckBoxState(secondCheckBox));

            SetCheckBoxState(secondCheckBox, false);

            Assert.False(GetCheckBoxState(secondCheckBox));
        }
        

        private void GoToCheckboxes()
        {
            IWebElement checkBoxLink = driver.FindElement(By.LinkText("Checkboxes"));
            checkBoxLink.Click();
        }
        private void SetCheckBoxState(IWebElement element, bool flag)
        {
            if (GetCheckBoxState(element) != flag) element.Click();
        }
        private bool GetCheckBoxState(IWebElement element)
        {
            return element.Selected;
        }
    }
}