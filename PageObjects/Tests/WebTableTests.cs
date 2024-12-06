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
    public class WebTableTests : BaseTest
    {
        private WebTablePage _table;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            WebDriverFactory.Driver.NavigateToUrl(TestSettings.WebTablePageUrl);
        }

        [SetUp]
        public void Setup()
        {
            _table = new WebTablePage();
        }

        [Test]
        public void WebTableCheck()
        {
            _table.WaitForTableDisplayed();
            _table.ScrollToTable();

            Assert.That(_table.IsTableDisplayed(), Is.True, "Таблица не отображается");

            var rows = _table.GetRows();
            var columns = _table.GetColumns();

            Assert.Multiple(() =>
            {
                Assert.That(rows?.Count > 0, Is.True, "Таблица не содержит строк");
                Assert.That(columns?.Count > 0, Is.True, "Таблица не содержит колонок");
            });

            _table.WaitForHeaderDisplayed();
            Assert.That(_table.GetFirstHeaderClassAttributeValue().Contains("-sort-desc"), Is.False, "Сортировка по убыванию включена.");

            var columnValuesBeforeSorting = _table.GetFirstColumnValues();

            _table.FirstColumnHeaderClick();
            Assert.That(_table.GetFirstHeaderClassAttributeValue().Contains("-sort-asc"), Is.True, "Сортировка по возрастанию не включена.");

            var columnValuesAfterSorting = _table.GetFirstColumnValues();
            var sortedValues = new List<string>(columnValuesBeforeSorting);
            sortedValues.Sort();

            Assert.That(columnValuesAfterSorting.SequenceEqual(sortedValues), Is.True, "Таблица не отсортирована по возрастанию.");
        }
    }
}
