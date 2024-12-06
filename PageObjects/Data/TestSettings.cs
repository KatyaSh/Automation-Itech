using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjects.Data
{
    public static class TestSettings
    {
        public static Browsers Browser { get; set; }
        public static string DemoQAHomePageUrl { get; set; }
        public static string CheckboxPageUrl { get; set; }
        public static string RadioButtonPageUrl { get; set; }
        public static string WebTablePageUrl { get; set; }
        public static string ButtonsPageUrl { get; set; }
        public static string LinksPageUrl { get; set; }
        public static string BrokenImagePageUrl { get; set; }
        public static string UploadAndDownloadPageUrl { get; set; }
        public static string DynamicPropertiesPageUrl { get; set; }
        public static IConfiguration TestConfiguration { get; } = new ConfigurationBuilder().AddJsonFile(".\\Tests\\testsettings.json").Build();

        static TestSettings()
        {
            Enum.TryParse(TestConfiguration["Common:Browser"], out Browsers browser);
            Browser = browser;
            DemoQAHomePageUrl = TestConfiguration["Common:DemoQAUrls:DemoQAHomePage"];
            CheckboxPageUrl = TestConfiguration["Common:DemoQAUrls:CheckboxPage"];
            RadioButtonPageUrl = TestConfiguration["Common:DemoQAUrls:RadioButtonPage"];
            WebTablePageUrl = TestConfiguration["Common:DemoQAUrls:WebTablePage"];
            ButtonsPageUrl = TestConfiguration["Common:DemoQAUrls:ButtonsPage"];
            LinksPageUrl = TestConfiguration["Common:DemoQAUrls:LinksPage"];
            BrokenImagePageUrl = TestConfiguration["Common:DemoQAUrls:BrokenImagePage"];
            UploadAndDownloadPageUrl = TestConfiguration["Common:DemoQAUrls:UploadAndDownloadPage"];
            DynamicPropertiesPageUrl = TestConfiguration["Common:DemoQAUrls:DynamicPropertiesPage"];
        }
    }
}
