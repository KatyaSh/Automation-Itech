using NUnit.Framework;
using OpenQA.Selenium;
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
    public class RadioButtonsTests : BaseTest
    {
        private RadioButtonsPage _radioButton;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            WebDriverFactory.Driver.NavigateToUrl(TestSettings.RadioButtonPageUrl);
        }

        [SetUp]
        public void Setup()
        {
            _radioButton = new RadioButtonsPage();
        }

        [Test]
        public void RadioButtonCheck()
        {
            _radioButton.WaitForYesRadioButtonDisplayed();
            Assert.That(_radioButton.IsYesRadioButtonSelected, Is.False, "Кнопка 'Yes' не выбрана по умолчанию.");

            _radioButton.WaitForYesRadioLabelDisplayed();
            Assert.That(_radioButton.GetYesRadioLabelText(), Is.EqualTo("Yes"), $"Текст радиокнопки 'Yes' неверен: {_radioButton.GetYesRadioLabelText} ");

            _radioButton.YesRadioLabelClick();
            _radioButton.WaitForResultOutputlDisplayed();
            Assert.Multiple(() =>
            {
                Assert.That(_radioButton.IsYesRadioButtonSelected, Is.True, "Кнопка 'Yes' должна быть выбрана!");
                Assert.That(_radioButton.GetResultOutputText(), Is.EqualTo("You have selected Yes"), "Текст по клику radiobutton неверен.");
                Assert.That(_radioButton.GetResultOutputText().Contains(_radioButton.GetYesRadioLabelText()), Is.True, "Ожидаемый текст отсутствует.");
            });
        }
    }
}
