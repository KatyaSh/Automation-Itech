using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PageObjects.Data;



namespace PageObjects.Common.Drivers
{
    public class WebDriverFactory
    {
        private static readonly ConcurrentDictionary<string, IWebDriver> DriverCollection = new ConcurrentDictionary<string, IWebDriver>();

        public static IWebDriver Driver
        {
            get
            {
                if (!DriverCollection.Keys.Contains(TestContextValues.ExecutableClassName))
                {
                    InitializeDriver();
                }

                return DriverCollection.First(pair => pair.Key == TestContextValues.ExecutableClassName).Value;
            }

            private set => DriverCollection.TryAdd(TestContextValues.ExecutableClassName, value);
        }

        public static Actions Actions => new Actions(Driver);

        public static IJavaScriptExecutor JavaScriptExecutor => (IJavaScriptExecutor)Driver;

        public static void QuitDriver() => Driver.Quit();

        private static void InitializeDriver()
        {
            Driver = TestSettings.Browser switch
            {
                Browsers.Chrome => new ChromeDriver(),
                Browsers.Edge => new EdgeDriver(),
                _ => throw new NotSupportedException(),
            };

            Driver.Manage().Window.Maximize();
        }
    }
}
