using Allure.Commons;
using Hometask15.Model;
using NUnit.Allure.Attributes;
using NUnit.Framework;


namespace Hometask15.Tests
{
    public class CreateNewContact : TestBase
    {
        [Test(Description ="Health check")]
        [AllureSeverity(SeverityLevel.critical)]
        [Description("Add contract with minimal data")]
        [AllureTag("Smoke")]
        [AllureOwner("Margarita")]
        [AllureSuite("Hometask15")]
        [AllureSubSuite("CreateNewContact")]
        [AllureIssue("JIRA-14")]
        [AllureTms("TMS-16")]
        public void CreateNewContact_OnlyRequiredAtts_Created()
        {
            var contact = new Contact();
            contact.LastName = Faker.NameFaker.LastName();

            appHelper.InitContactCreation(UserBuilder.GetSalesForceUser())
                     .FillNewContactForm(contact)
                     .ConfirmContactCreation()
                     .ReloadContacts()
                     .CheckContactWithAttExist(contact.LastName);
        }

        [Test]
        [AllureSuite("Hometask15")]
        [AllureSubSuite("CreateNewContact")]
        public void CreateNewContact_Cancel_NotCreated()
        {
            var contact = new Contact();
            contact.LastName = Faker.NameFaker.LastName();

            appHelper.InitContactCreation(UserBuilder.GetSalesForceUser())
                     .FillNewContactForm(contact)
                     .CancelContractCreation()
                     .ReloadContacts()
                     .CheckContactWithAttExist(contact.LastName);
        }
    }
}
