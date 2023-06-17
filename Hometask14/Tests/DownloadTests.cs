using FluentAssertions;
using Hometask14.Helpers;
using Hometask14.Pages;
using NUnit.Framework;


namespace Hometask14.Tests
{
    public class DownloadTests : TestBase
    {
        public string fileName = "sampleFile.jpeg";

        [OneTimeSetUp]
        public void CleanData()
        {
            DirectoryHelper.RemoveFile(fileName);
        }

        [Test]
        public void DownoloadTest()
        {
            var page = new DemoQA().Open();

            page.DownloadFile();

            DirectoryHelper.CheckFileExist(fileName).Should().Be(true);
        }
    }
}
