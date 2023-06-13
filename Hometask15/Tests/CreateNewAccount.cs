using Hometask15.Model;
using Hometask15.Pages;
using NUnit.Framework;

namespace Hometask15.Tests
{
    public class CreateNewAccount : TestBase
    {
        [Test]
        public void CreateNewAccount_OnlyRequiredAtts_Created()
        {
            var account = new Account();
            account.AccountName = Faker.InternetFaker.Email();

            appHelper.InitAccountCreation(UserBuilder.GetSalesForceUser())
                     .FillNewAccountForm(account)
                     .ConfirmAccountCreation()
                     .ReloadAccounts()
                     .CheckAccountWithAttExist(account.AccountName);
        }
    }
}
