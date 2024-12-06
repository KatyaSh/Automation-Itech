

using NUnit.Framework;
using PageObjects.Common.Drivers;
using PageObjects.Common.Exstensions;
using PageObjects.Data;
using PageObjects.PageObjects.DemoQA.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PageObjects.Tests
{
    public class BrokenLinkImageTests : BaseTest
    {
        private BrokenLinkImagePage _link;
        private HttpClient? _client;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            WebDriverFactory.Driver.NavigateToUrl(TestSettings.BrokenImagePageUrl);
        }

        [SetUp]
        public void Setup()
        {
            _link = new BrokenLinkImagePage();
            _client = new HttpClient();
        }

        [Test]
        public async Task CheckBrokenImageAsync()
        {
            _link.WaitForBrokenLnkIsDisplayed();
            Assert.That(_link.GetBrokenImageAttributeValue("src"), Is.Not.Null, "Атрибут src изображения не задан.");

            var response = await _client?.GetAsync(_link.GetAbsoluteUrlForImageLink("src"));
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK), "Неверный статус код ответа сервера.");

            var contentType = response.Content.Headers.ContentType?.ToString();
            Assert.Multiple(() =>
            {
                Assert.That(contentType, Is.Not.Null, "Content-Type отсутствует в ответе сервера.");
                Assert.That(contentType.StartsWith("image/"), Is.True, $"Неверный Content-Type: {contentType}. Ожидается image.");
            });
        }
    }
}
