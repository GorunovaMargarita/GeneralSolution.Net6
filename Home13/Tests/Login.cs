using Home13.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home13.Tests
{
    [TestFixture]
    internal class Login : BaseTest
    {
        [Test]
        public void Login_StandartUser_Ok()
        {
            new LoginPage(driver).Open().Login(TestData.TestUsers.Standart).CheckPorductsLoaded();
        }
        [Test]
        public void Login_UnknownUser_Error()
        {
            new LoginPage(driver).Open().TryToLogin(TestData.TestUsers.UnknownLoginPass).VerifyErrorMessage(Constants.LoginErrorMessages.UserNotExist);
        }
    }
}
