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
    public class DynamicPropertiesTests : BaseTest
    {
        private DynamicPropertiesPage _dynamicProperties;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            WebDriverFactory.Driver.NavigateToUrl(TestSettings.DynamicPropertiesPageUrl);
        }

        [SetUp]
        public void Setup()
        {
            _dynamicProperties = new DynamicPropertiesPage();
        }

        [Test]
        public void ButtonVisibleAfterCheck()
        {
            _dynamicProperties.WaitForButtonVisibleAfterExistsAndDisplayed();
            _dynamicProperties.ScrollToButton();
            Assert.That(_dynamicProperties.isButtonDisplayed, Is.True, "Кнопка visibleAfterButton не отображается.");
        }

        [Test]
        public void ColoredButtonCheck()
        {
            WebDriverFactory.Driver.RefreshBrowserPage();
            _dynamicProperties.WaitForColoredButtonDisplayed();
            _dynamicProperties.ScrollToChangeButton();
            var expectedColor = _dynamicProperties.GetCssValueChangeButton("color");
            var actualColor = _dynamicProperties.GetCssValueColoredButtonAfterChange("color");
            _dynamicProperties.WaitForColoredButtonAfterChangeDisplayed();
            Assert.That(actualColor.Equals(expectedColor), Is.False, $" цвет кнопки до изменения: {expectedColor}, цвет кнопки после изменения: {actualColor}");
        }
    }
}
