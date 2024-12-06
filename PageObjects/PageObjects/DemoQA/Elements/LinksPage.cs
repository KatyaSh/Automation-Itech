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
    public class LinksPage
    {
        private static By SimpleLinkLocator = By.Id("simpleLink");
        private static By CreatedLinkLocator = By.Id("created");
        private static By LinkResponseLocator = By.LinkText("Created");
        private MyWebElement _simpleLink = new(SimpleLinkLocator);
        private MyWebElement _createdLink = new(CreatedLinkLocator);
        private MyWebElement _linkResponse = new(LinkResponseLocator);

        public void ScrollToSimpleLink() => _simpleLink.ScrollIntoView();

        public void SimpleLinkClick() => _simpleLink.Click();

        public void ScrollToCreatedLink() => _createdLink.ScrollIntoView();

        public void CreatedLinkClick() => _createdLink.Click();

        public string GetLinkResponceText() => _linkResponse.Text;

        public IWebElement WaitForSimpleLinkDisplayed() => WebDriverFactory.Driver.GetWebElementWhenExists(SimpleLinkLocator);

        public IWebElement WaitForCreatedLinkDisplayed() => WebDriverFactory.Driver.GetWebElementWhenExists(CreatedLinkLocator);

        public IWebElement WaitForlinkResponseDisplayed() => WebDriverFactory.Driver.GetWebElementWhenExists(LinkResponseLocator);
    }
}
