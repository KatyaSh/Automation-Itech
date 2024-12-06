using NUnit.Framework;
using PageObjects.Common.Drivers;
using PageObjects.Common.Exstensions;
using PageObjects.Data;
using PageObjects.PageObjects.DemoQA.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PageObjects.Utils;
using PageObjects.Common.WebElements;
using OpenQA.Selenium;

namespace PageObjects.Tests
{
    public class UploadAndDownloadTests : BaseTest
    {
        private UploadAndDownloadButtonsPage _button;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            WebDriverFactory.Driver.NavigateToUrl(TestSettings.UploadAndDownloadPageUrl);
        }

        [SetUp]
        public void Setup()
        {
            _button = new UploadAndDownloadButtonsPage();
        }

        [Test]
        public void DownloadButtonCheck()
        {
            _button.WaitForDownloadButtonDisplayed();
            _button.ScrollToDownloadButton();
            Assert.That(_button.IsDownloadButtonDisplayed(), Is.True, "Кнопка скачивания файла (Download) не отображается.");

            _button.DownloadButtonClick();

            var downloadPath = FileUtils.GetDownloadPath();
            var expectedFileName = "sampleFile.jpeg";
            var fullFilePath = FileUtils.GetFullDownloadedFilePath(downloadPath, expectedFileName);

            Assert.That(File.Exists(fullFilePath), Is.True, $"Файл {expectedFileName} не найден в папке загрузок.");
        }

        [Test]
        public void UploadButtonCheck()
        {
            var projectDirectory = FileUtils.GetProjectDirectory();
            var fileName = "testfile.txt";
            var filePath = FileUtils.GetFilePathToBeUploaded(projectDirectory, "TestFiles", fileName);

            _button.ScrollToUploadButton();
            Assert.That(_button.IsUploadButtonDisplayed(), Is.True, "Кнопка загрузки файла (Upload) не отображается.");

            _button.UploadFile(filePath);
            _button.WaitForUploadedFilePathDisplayed();
            Assert.That(_button.GetUploadedFilePath().Contains(fileName), Is.True, "Файл не был загружен.");
        }
    }
}
