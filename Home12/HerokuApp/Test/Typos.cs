using NuGet.Frameworks;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
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
    public class Typos : BaseTest
    {
        [Test]
        [Retry(10)]
        public void InputInteger()
        {
            string correctVal = "Sometimes you'll see a typo, other times you won't.";
            GoToTypos();
            IWebElement typos = driver.FindElement(By.CssSelector("p:last-child"));

            Assert.AreEqual(correctVal, typos.Text);

            driver.Navigate().Refresh();

            typos = driver.FindElement(By.CssSelector("p:last-child"));

            Assert.AreEqual(correctVal, typos.Text);
        }
        private void GoToTypos()
        {
            IWebElement Typos = driver.FindElement(By.LinkText("Typos"));
            Typos.Click();
        }
    }
}