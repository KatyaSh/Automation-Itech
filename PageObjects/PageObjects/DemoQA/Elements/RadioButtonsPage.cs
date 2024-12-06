using PageObjects.Common.WebElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using PageObjects.Common.Drivers;
using PageObjects.Common.Exstensions;

namespace PageObjects.PageObjects.DemoQA.Elements
{
    public class RadioButtonsPage
    {
        private static By YesRadioButtonLocator = By.Id("yesRadio");
        private static By YesRadioLabelLocator = By.XPath("//*[@id=\"yesRadio\"]//following-sibling::label");
        private static By ResultOutputLocator = By.XPath("//*[@id=\"yesRadio\"]//following::p");
        private MyWebElement _yesRadioButton = new(YesRadioButtonLocator);
        private MyWebElement _yesRadioLabel = new(YesRadioLabelLocator);
        private MyWebElement _resultOutput = new(ResultOutputLocator);

        public bool IsYesRadioButtonSelected() => _yesRadioButton.Selected;

        public string GetYesRadioLabelText() => _yesRadioLabel.Text;

        public void YesRadioLabelClick() => _yesRadioLabel.Click();

        public string GetResultOutputText() => _resultOutput.Text;

        public IWebElement WaitForYesRadioButtonDisplayed() => WebDriverFactory.Driver.GetWebElementWhenExists(YesRadioButtonLocator);

        public IWebElement WaitForYesRadioLabelDisplayed() => WebDriverFactory.Driver.GetWebElementWhenExists(YesRadioLabelLocator);

        public IWebElement WaitForResultOutputlDisplayed() => WebDriverFactory.Driver.GetWebElementWhenExists(ResultOutputLocator);
    }
}
