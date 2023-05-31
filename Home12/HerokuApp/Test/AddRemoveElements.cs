using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home12.HerokuApp.Test
{
    [TestFixture]
    public class AddRemoveElements : BaseTest
    { 
        [Test]
        public void AddOneElement()
        {
            GoToAddRemoveElement();
            AddElement(1);
            Assert.That(GetElementCount() == 1);
        }
        [Test]
        public void AddTwoElements()
        {
            GoToAddRemoveElement();
            AddElement(2);
            Assert.That(GetElementCount() == 2);
        }
        [Test]
        public void AddAndDeleteOneElement()
        {
            GoToAddRemoveElement();
            AddElement(1);
            DeleteElement(1);
            Assert.That(GetElementCount() == 0);
        }

        [Test]
        public void AddTwoAndDeleteOneElement()
        {
            GoToAddRemoveElement();
            AddElement(2);
            DeleteElement(1);
            Assert.That(GetElementCount() == 1);
        }

        By DeleteButton = By.XPath("//button[text()='Delete']");
        By AddRemoveElementLink = By.XPath("//a[@href='/add_remove_elements/']");
        By AddElementButton = By.XPath("//button[text()='Add Element']");

        private int GetElementCount()
        {
            return driver.FindElements(DeleteButton).Count();
        }

        private void AddElement(int elementCount)
        {
            for (int i = 0; i < elementCount; i++)
            {
                driver.FindElement(AddElementButton).Click();
            }
        }

        private void GoToAddRemoveElement()
        {
            driver.FindElement(AddRemoveElementLink).Click();
        }
        private void DeleteElement(int elementCount)
        {
            for(int i = 0; i < elementCount; i++)
            {
                driver.FindElement(DeleteButton).Click();
            }
        }
    }
}