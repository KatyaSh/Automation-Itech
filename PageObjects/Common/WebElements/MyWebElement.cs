using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using PageObjects.Common.Drivers;
using PageObjects.Common.Exstensions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjects.Common.WebElements
{
    public class MyWebElement : IWebElement
    {
        public MyWebElement(By by)
        {
            By = by;
        }

        protected By By { get; set; }

        protected IWebElement WebElement => WebDriverFactory.Driver.GetWebElementWhenExists(By);               

        public string TagName => WebElement.TagName;

        public string Text => WebElement.Text;

        public bool Enabled => WebElement.Enabled;

        public bool Selected => WebElement.Selected;

        public Point Location => WebElement.Location;

        public Size Size => WebElement.Size;

        public bool Displayed => WebElement.Displayed;

        public void Clear() => WebElement.Clear();

        public void Click()
        {
            ScrollIntoView();
            WebElement.Click();
        }

        public void ScrollIntoView() => WebDriverFactory.JavaScriptExecutor.ExecuteScript("arguments[0].scrollIntoView()", WebElement);

        public void RightClick() => WebDriverFactory.Actions.ContextClick(WebElement).Perform();

        public void DoubleClick() => WebDriverFactory.Actions.DoubleClick(WebElement).Perform();

        public IWebElement FindElement(By by) => WebElement.FindElement(by);

        public ReadOnlyCollection<IWebElement> FindElements(By by)
        {
            try
            {
                return WebElement.FindElements(by);
            }
            catch (StaleElementReferenceException)
            {
                return WebElement.FindElements(by);
            }
        }

        public string GetAttribute(string attributeName) => WebElement.GetAttribute(attributeName);

        public string GetCssValue(string propertyName) => WebElement.GetCssValue(propertyName);

        public string GetDomAttribute(string attributeName) => WebElement.GetDomAttribute(attributeName);

        public string GetDomProperty(string propertyName) => WebElement.GetDomProperty(propertyName);

        public ISearchContext GetShadowRoot() => WebElement.GetShadowRoot();

        public void SendKeys(string text) => WebElement.SendKeys(text);

        public void Submit() => WebElement.Submit();

        public string GetClassAttributeValue() => WebElement.GetAttribute("class");
    }
}
