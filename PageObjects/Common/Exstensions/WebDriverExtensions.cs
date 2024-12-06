using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace PageObjects.Common.Exstensions
{
    public static class WebDriverExtensions
    {
        public static WebDriverWait GetWebDriverWait(this IWebDriver driver, int timeoutSeconds = 30, TimeSpan? pollingInterval = null, params Type[] exceptionTypes)
        {
            var webDriverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutSeconds));
            if (pollingInterval != null)
            {
                webDriverWait.PollingInterval = (TimeSpan)pollingInterval;
            }

            webDriverWait.IgnoreExceptionTypes(exceptionTypes);

            return webDriverWait;
        }

        public static void SwitchToWindow(this IWebDriver driver, int windowIndex) => driver.SwitchTo().Window(driver.WindowHandles[windowIndex]);

        public static void NavigateToUrl(this IWebDriver driver, string pageUrl) => driver.Navigate().GoToUrl(pageUrl);

        public static string GetBrowserUrl(this IWebDriver driver) => driver.Url;

        public static void RefreshBrowserPage(this IWebDriver driver) => driver.Navigate().Refresh();

        public static string GetAbsoluteUrl(this IWebDriver driver, string src) => new Uri(new Uri(driver.Url), src).ToString();

        public static int GetBrowserTabsCount(this IWebDriver driver) => driver.WindowHandles.Count();

        public static IWebElement GetWebElementWhenExists(this IWebDriver driver, By by) => driver.GetWebDriverWait().Until(drv => drv.FindElement(by));

        public static IWebElement GetWebElementWhenExistsAndDisplayed(this IWebDriver driver, By by)
        {
            var element = GetWebElementWhenExists(driver, by);
            return element.Displayed ? element : null;
        }       
    } 
}
