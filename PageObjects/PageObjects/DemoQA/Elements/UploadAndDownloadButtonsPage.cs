using OpenQA.Selenium;
using PageObjects.Common.Drivers;
using PageObjects.Common.Exstensions;
using PageObjects.Common.WebElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjects.PageObjects.DemoQA.Elements
{
    public class UploadAndDownloadButtonsPage
    {
        private static By DownloadButtonLocator = By.Id("downloadButton");
        private static By UploadButtonLocator = By.XPath("//input[@id = 'uploadFile']");
        private static By UploadedFilePathLocator = By.XPath("//p[@id='uploadedFilePath']");
        private MyWebElement _uploadButton = new(UploadButtonLocator);
        private MyWebElement _uploadedFilePath = new(UploadedFilePathLocator);
        private MyWebElement _downloadButton = new(DownloadButtonLocator);
        
        public void ScrollToUploadButton() => _uploadButton.ScrollIntoView();

        public bool IsUploadButtonDisplayed() => _uploadButton.Displayed;

        public void UploadFile(string filePath) => _uploadButton.SendKeys(filePath);

        public string GetUploadedFilePath() => _uploadedFilePath.Text;

        public void ScrollToDownloadButton() => _downloadButton.ScrollIntoView();

        public bool IsDownloadButtonDisplayed() => _downloadButton.Displayed;

        public void DownloadButtonClick() => _downloadButton.Click();

        public void UploadButtonClick() => _uploadButton.Click();

        public IWebElement WaitForDownloadButtonDisplayed() => WebDriverFactory.Driver.GetWebElementWhenExists(DownloadButtonLocator);

        public IWebElement WaitForUploadButtonDisplayed() => WebDriverFactory.Driver.GetWebElementWhenExists(UploadButtonLocator);

        public IWebElement WaitForUploadedFilePathDisplayed() => WebDriverFactory.Driver.GetWebElementWhenExists(UploadedFilePathLocator);
    }
}
