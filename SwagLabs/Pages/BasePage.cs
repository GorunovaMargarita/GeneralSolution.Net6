using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwagLabs.Pages
{
    public class BasePage
    {
        protected WebDriver driver;
        public BasePage(WebDriver driver) 
        {
            this.driver = driver;
        }

    }
}
