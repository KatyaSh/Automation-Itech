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
    public class ButtonsTests : BaseTest
    {
        private ButtonsPage _button;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            WebDriverFactory.Driver.NavigateToUrl(TestSettings.ButtonsPageUrl);
        }

        [SetUp]
        public void Setup()
        {
            _button = new ButtonsPage();
        }

        [Test]
        public void DoubleClickButtonCheck()
        {
            var expectedResultForDoubleClick = "You have done a double click";

            _button.ScrollToDoubleClickButton();
            _button.DoubleClickBtn();
            Assert.That(_button.GetDoubleClickMessage(), Is.EqualTo(expectedResultForDoubleClick), "Ошибка в тексте двойного клика.");
        }

        [Test]
        public void RightClickButtonCheck()
        {
            var expectedResultForRightClick = "You have done a right click";

            _button.ScrollToRightClickButton();
            _button.RightClickBtn();
            Assert.That(_button.GetRightClickMessage(), Is.EqualTo(expectedResultForRightClick), "Ошибка в тексте правого клика.");
        }

        [Test]
        public void SimpleClickButtonCheck()
        {
            var expectedResultForDynamicClick = "You have done a dynamic click";

            _button.SimpleButtonClick();
            Assert.That(_button.GetSimpleMessage(), Is.EqualTo(expectedResultForDynamicClick), "Ошибка в тексте простого клика.");
        }
    }
}
