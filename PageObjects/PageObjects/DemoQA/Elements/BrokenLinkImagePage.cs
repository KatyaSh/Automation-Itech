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
    public class BrokenLinkImagePage
    {
        private static By BrokenImageLocator = By.XPath("//p[text()='Broken image']//following-sibling::img");
        private MyWebElement _brokenImage = new(BrokenImageLocator);

        public string GetBrokenImageAttributeValue(string attributeName) => _brokenImage.GetAttribute(attributeName);

        public IWebElement WaitForBrokenLnkIsDisplayed() => WebDriverFactory.Driver.GetWebElementWhenExists(BrokenImageLocator);

        public string GetAbsoluteUrlForImageLink(string attributeName) => WebDriverFactory.Driver.GetAbsoluteUrl(_brokenImage.GetAttribute(attributeName));
    }
}
