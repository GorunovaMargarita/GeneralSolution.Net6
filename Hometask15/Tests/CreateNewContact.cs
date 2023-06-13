using Hometask15.Model;
using NUnit.Framework;


namespace Hometask15.Tests
{
    public class CreateNewContact : TestBase
    {
        [Test]
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
    }
}
