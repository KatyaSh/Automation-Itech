using OpenQA.Selenium;
using OpenQA.Selenium.BiDi;
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
    public class DynamicPropertiesPage
    {
        private static By ChangeButtonLocator = By.Id("colorChange");
        private static By ColoredButtonAfterChangeLocator = By.XPath("//button[contains(@class,'text-danger')]");
        private static By ButtonVisibleAfterLocator = By.XPath("//button[@id='visibleAfter']");
        private MyWebElement _button = new(ButtonVisibleAfterLocator);
        private MyWebElement _changeButton = new(ChangeButtonLocator);
        private MyWebElement _coloredButtonAfterChange = new(ColoredButtonAfterChangeLocator);

        public bool isButtonDisplayed() => _button.Displayed;

        public void ScrollToButton() => _button.ScrollIntoView();

        public void ScrollToChangeButton() => _changeButton.ScrollIntoView();

        public string GetCssValueChangeButton(string value) => _changeButton.GetCssValue(value);

        public string GetCssValueColoredButtonAfterChange(string value) => _coloredButtonAfterChange.GetCssValue(value);

        public IWebElement WaitForButtonVisibleAfterExistsAndDisplayed() => WebDriverFactory.Driver.GetWebElementWhenExistsAndDisplayed(ButtonVisibleAfterLocator);

        public IWebElement WaitForColoredButtonDisplayed() => WebDriverFactory.Driver.GetWebElementWhenExists(ChangeButtonLocator);

        public IWebElement WaitForColoredButtonAfterChangeDisplayed() => WebDriverFactory.Driver.GetWebElementWhenExists(ColoredButtonAfterChangeLocator);
    }
}
