using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using PageObjects.Common.Drivers;
using PageObjects.Common.Exstensions;
using PageObjects.Common.WebElements;

namespace PageObjects.PageObjects.DemoQA.Elements
{
    public class CheckboxPage
    {
        private static By CheckboxLocator = By.XPath("//span[contains(@class,'rct-checkbox')]/*[local-name()='svg']");
        private MyWebElement _checkbox = new(CheckboxLocator);
        private MyWebElement _resultTextElement = new(By.XPath("//div[@id=\"result\"]/span[1]"));

        public bool IsCheckboxDisplayed() => _checkbox.Displayed;

        public bool IsCheckboxEnabled() => _checkbox.Enabled;

        public void CheckboxClicked() => _checkbox.Click();

        public string GetCheckboxClassAttributeValue() => _checkbox.GetClassAttributeValue();

        public IWebElement WaitForCheckboxIsDisplayed() => WebDriverFactory.Driver.GetWebElementWhenExists(CheckboxLocator);

        public string GetTextFromResultElement() => _resultTextElement.Text;
    }
}
