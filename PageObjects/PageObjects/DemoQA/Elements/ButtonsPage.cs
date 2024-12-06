using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using PageObjects.Common.WebElements;

namespace PageObjects.PageObjects.DemoQA.Elements
{
    public class ButtonsPage
    {
        private MyWebElement _doubleClickButton = new(By.Id("doubleClickBtn"));
        private MyWebElement _rightClickButton = new(By.Id("rightClickBtn"));
        private MyWebElement _doubleClickMessage = new(By.Id("doubleClickMessage"));
        private MyWebElement _rightClickMessage = new(By.Id("rightClickMessage"));
        private MyWebElement _simpleButton = new(By.XPath("//button[text()='Click Me']"));
        private MyWebElement _simpleMessage = new(By.Id("dynamicClickMessage"));

        public void DoubleClickBtn() => _doubleClickButton.DoubleClick();

        public void RightClickBtn() => _rightClickButton.RightClick();

        public void ScrollToDoubleClickButton() => _doubleClickButton.ScrollIntoView();

        public void ScrollToRightClickButton() => _rightClickButton.ScrollIntoView();

        public string GetDoubleClickMessage() => _doubleClickMessage.Text;

        public string GetRightClickMessage() => _rightClickMessage.Text;

        public void SimpleButtonClick() => _simpleButton.Click();

        public string GetSimpleMessage() => _simpleMessage.Text;
    }
}
