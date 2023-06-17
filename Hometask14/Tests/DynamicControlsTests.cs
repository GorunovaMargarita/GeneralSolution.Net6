using FluentAssertions;
using Hometask14.Helpers;
using Hometask14.Pages;
using NUnit.Framework;

namespace Hometask14.Tests
{
    [TestFixture]
    public class DynamicControlsTests : TestBase
    {
        [Test]
        public void CheckBoxTest()
        {
            var page = new DynamicControls().Open();
            Browser.Instance.Driver.FindElement(page.CheckBox);

            Browser.Instance.Driver.FindElement(page.RemoveCheckBoxButton).Click();

            WaitHelper.WaitElement(Browser.Instance.Driver, page.CheckBoxGone);

            var checkBoxes = Browser.Instance.Driver.FindElements(page.CheckBox);
            checkBoxes.Should().HaveCount(0);
        }

        [Test]
        public void TextInputTest()
        {
            var page = new DynamicControls().Open();
            var element = Browser.Instance.Driver.FindElement(page.TextInput);

            element.Enabled.Should().Be(false);

            Browser.Instance.Driver.FindElement(page.EnableTextInput).Click();

            WaitHelper.WaitElement(Browser.Instance.Driver, page.TextInputEnabled);

            element = Browser.Instance.Driver.FindElement(page.TextInput);

            element.Enabled.Should().Be(true);
        }
    }
}
