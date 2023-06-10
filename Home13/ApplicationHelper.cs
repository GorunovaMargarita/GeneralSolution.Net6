using Home13.Pages;
using Model;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home13
{
    public class ApplicationHelper
    {
        protected WebDriver driver;
        public ApplicationHelper(WebDriver driver)
        {
            this.driver = driver;
        }
        public void InitOrder(User user)
        {
            new LoginPage(driver).Open()
                                 .Login(TestData.TestUsers.Standart)
                                 .CheckPorductsLoaded();
        }
        public void AddProductsToCart(int quantity)
        {
            for(int i = 0; i < quantity; i++)
            {
                new InventoryPage(driver).AddRandomProduct();
            }
        }
        public void FinishProductOrder()
        {
            new CartPage(driver).GoToCheckoutPage()
                                .FillCheckoutForm()
                                .ContinueCheckout()
                                .FinishOrder()
                                .VerifySuccessMessage();
        }
    }
}
