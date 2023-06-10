using Hometask14.Pages;
using NUnit.Framework;


namespace Hometask14.Tests
{
    public class FileUploaderTest : TestBase
    {
        [Test]
        public void UploadTest()
        {
            string relativeFilePath = "\\TestData\\HW.docx";
            string fileName = "HW.docx";

            new FileUploader().Open()
                              .ChooseFile(relativeFilePath)
                              .CheckFileNameBeforeUpload(fileName)
                              .UploadChoosenFile()
                              .CheckSuccessUpload(fileName);
        }
    }
}
