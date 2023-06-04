using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home13.Pages
{
    public abstract class BasePage
    {
        protected WebDriver driver;
        public BasePage(WebDriver driver)
        {
            this.driver = driver;
        }

        public abstract BasePage Open();
    }
}
