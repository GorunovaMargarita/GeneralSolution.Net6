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
    public class Inputs : BaseTest
    {
        [Test]
        public void InputInteger([Values(0, 5, 15, 181, 4578, 12454, 15487554)] int value)
        {
            GoToInputs();
            IWebElement input = driver.FindElement(By.TagName("input"));
            input.SendKeys(value.ToString());

            Assert.AreEqual(value.ToString(), input.GetAttribute("value"));
        }

        [Test]
        public void InputDouble([Values("1.1", "2.56", "54545.545454")] string value)
        {
            GoToInputs();
            IWebElement input = driver.FindElement(By.TagName("input"));
            input.SendKeys(value);

            Assert.AreEqual(value, input.GetAttribute("value"));
        }
        [Test]
        public void InputNumberInExponentView([Values("1e-10", "6e+17", "0.66E-007")] string value)
        {
            GoToInputs();
            IWebElement input = driver.FindElement(By.TagName("input"));
            input.SendKeys(value);

            Assert.AreEqual(value, input.GetAttribute("value"));
        }
        [Test]
        public void InputWithArrowUp()
        {
            GoToInputs();
            IWebElement input = driver.FindElement(By.TagName("input"));
            input.SendKeys(Keys.ArrowUp);

            Assert.AreEqual("1", input.GetAttribute("value"));

            input.SendKeys(Keys.ArrowUp);
            input.SendKeys(Keys.ArrowUp);

            Assert.AreEqual("3", input.GetAttribute("value"));

            input.SendKeys("100");
            input.SendKeys(Keys.ArrowUp);

            Assert.AreEqual("3101", input.GetAttribute("value"));
        }
        [Test]
        public void InputWithArrowDown()
        {
            GoToInputs();
            IWebElement input = driver.FindElement(By.TagName("input"));
            input.SendKeys(Keys.ArrowDown);

            Assert.AreEqual("-1", input.GetAttribute("value"));

            input.SendKeys(Keys.ArrowDown);
            input.SendKeys(Keys.ArrowDown);

            Assert.AreEqual("-3", input.GetAttribute("value"));

            input.SendKeys(Keys.Backspace);
            input.SendKeys(Keys.Backspace);
            input.SendKeys("100");
            input.SendKeys(Keys.ArrowDown);

            Assert.AreEqual("99", input.GetAttribute("value"));
        }
        [TestCase("1ee","")]
        [TestCase("554e1e", "554e1")]
        [TestCase("2..5", "2.5")]
        [TestCase("1,1", "11")]
        [TestCase("some", "")]
        public void IncorrectValues(string inputVal, string resultVal)
        {
            GoToInputs();
            IWebElement input = driver.FindElement(By.TagName("input"));
            input.SendKeys(inputVal);

            Assert.AreEqual(resultVal, input.GetAttribute("value"));
        }
        private void GoToInputs()
        {
            IWebElement InputsLink = driver.FindElement(By.LinkText("Inputs"));
            InputsLink.Click();
        }
    }
}