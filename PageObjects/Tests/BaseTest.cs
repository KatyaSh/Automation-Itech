using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using PageObjects.Common.Drivers;
using PageObjects.Common.Exstensions;
using PageObjects.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjects.Tests
{
    public class BaseTest
    {      
        [OneTimeSetUp]
        public void BaseSetUp()
        {
            WebDriverFactory.Driver.NavigateToUrl(TestSettings.DemoQAHomePageUrl);
        }

        [OneTimeTearDown]
        public void BaseTestOneTimeTearDown()
        {
            WebDriverFactory.QuitDriver();
        }        
    }
}
