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
    public class CheckboxTests : BaseTest
    {
        private CheckboxPage _checkbox;        

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            WebDriverFactory.Driver.NavigateToUrl(TestSettings.CheckboxPageUrl);
        }

        [SetUp]
        public void Setup()
        {
            _checkbox = new CheckboxPage();            
        }

        [Test]
        public void CheckboxCheck()
        {
            var resultText = "You have selected :";
            _checkbox.WaitForCheckboxIsDisplayed();

            Assert.Multiple(() =>
            {
                Assert.That(_checkbox.IsCheckboxDisplayed(), Is.True, "Чекбокс не отображается!");
                Assert.That(_checkbox.IsCheckboxEnabled(), Is.True, "Чекбокс не активен!");
                Assert.That(_checkbox.GetCheckboxClassAttributeValue().Contains("-uncheck"), Is.True, "Чекбокс уже выбран!");
            });

            _checkbox.CheckboxClicked();
            Assert.Multiple(() =>
            {
                Assert.That(_checkbox.GetCheckboxClassAttributeValue().Contains("-check"), Is.True, "Чекбокс не выбран!");
                Assert.That(_checkbox.GetTextFromResultElement(), Is.EqualTo(resultText), "Ожидаемый текст по клику чекбокса не отображается.");
            });
        }
    }
}

