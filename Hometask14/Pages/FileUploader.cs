using FluentAssertions;
using OpenQA.Selenium;

namespace Hometask14.Pages
{
    public class FileUploader : BasePage
    {
        private static string url = "http://the-internet.herokuapp.com/upload";
        public By FileInput = By.Id("file-upload");
        public By FileSubmitButton = By.Id("file-submit");
        public By FileName = By.Id("uploaded-files");
        public By SuccessMessageText = By.XPath("//*[contains(text(),'File Uploaded')]");

        public override FileUploader Open()
        {
            driver.Navigate().GoToUrl(url);
            return this;
        }

        public FileUploader ChooseFile(string relativeFilePath)
        {
            driver.FindElement(FileInput).SendKeys(Environment.CurrentDirectory + relativeFilePath);
            return this;
        }

        public FileUploader CheckFileNameBeforeUpload(string fileName)
        {
            var fileNameFromPage = driver.FindElement(FileInput).GetAttribute("value").Split("\\").Last();

            fileNameFromPage.Should().Be(fileName);
            return this;
        }

        public FileUploader UploadChoosenFile()
        {
            driver.FindElement(FileSubmitButton).Click();
            return this;
        }

        public FileUploader CheckSuccessUpload(string fileName)
        {
            var fileNameFromPage = driver.FindElement(FileName).Text;
            fileNameFromPage.Should().Be(fileName);
            driver.FindElement(SuccessMessageText);
            return this;
        }
    }
}
