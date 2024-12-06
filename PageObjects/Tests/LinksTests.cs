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

namespace PageObjects.Tests
{
    public class LinksTests : BaseTest
    {
        private LinksPage _links;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            WebDriverFactory.Driver.NavigateToUrl(TestSettings.LinksPageUrl);
        }

        [SetUp]
        public void Setup()
        {
            _links = new LinksPage();
        }

        [Test]
        public void SimpleLinkCheck()
        {
            var expectedTabsCount = WebDriverFactory.Driver.GetBrowserTabsCount();
            _links.WaitForSimpleLinkDisplayed();
            _links.SimpleLinkClick();
            var actualTabsCount = WebDriverFactory.Driver.GetBrowserTabsCount();
            WebDriverFactory.Driver.SwitchToWindow(1);
            var actualBrowserUrl = WebDriverFactory.Driver.GetBrowserUrl();
            Assert.Multiple(() =>
            {
                Assert.That(actualTabsCount > expectedTabsCount, Is.True, $"Новая вкладка браузера не появилась.Количество вкладок браузера: {actualTabsCount}");
                Assert.That(actualBrowserUrl, Is.EqualTo("https://demoqa.com/"), $"Неверный URL в новой вкладке: {actualBrowserUrl}.");
            });
        }

        [Test]
        public void CreatedLinkCheck()
        {
            _links.WaitForCreatedLinkDisplayed();
            _links.CreatedLinkClick();
            _links.WaitForlinkResponseDisplayed();
            Assert.That(_links.GetLinkResponceText, Is.EqualTo("Created"), $"Текст ссылки неверен : {_links.GetLinkResponceText}.");
        }
    }
}
