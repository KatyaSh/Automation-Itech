using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using PageObjects.Common.WebElements;
using PageObjects.Common.Exstensions;
using PageObjects.Common.Drivers;

namespace PageObjects.PageObjects.DemoQA.Elements
{
    public class WebTablePage
    {
        private static By TableLocator = By.XPath("//div[contains(@class,'rt-table')]");
        private static By RowsLocator = By.XPath("//div[contains(@role,'rowgroup')]");
        private static By ColumnsLocator = By.XPath("//div[contains(@role,'columnheader')][1]");
        private static By GridCellsLocator = By.XPath("//div[contains(@role,'rowgroup')]//div[contains(@role,'gridcell')][1]");
        private MyWebElement _table = new(TableLocator);
        private MyWebElement _firstColumnHeader = new(ColumnsLocator);

        public void ScrollToTable() => _table.ScrollIntoView();

        public bool IsTableDisplayed() => _table.Displayed;

        public ReadOnlyCollection<IWebElement> GetRows() => _table.FindElements(RowsLocator);

        public ReadOnlyCollection<IWebElement> GetColumns() => _table.FindElements(ColumnsLocator);

        public string GetFirstHeaderClassAttributeValue() => _firstColumnHeader.GetClassAttributeValue();

        public void FirstColumnHeaderClick() => _firstColumnHeader.Click();

        public List<string> GetFirstColumnValues() => _table.FindElements(GridCellsLocator)
            .Select(cell => cell.Text)
            .Where(text => !string.IsNullOrWhiteSpace(text))
            .ToList();

        public IWebElement WaitForTableDisplayed() => WebDriverFactory.Driver.GetWebElementWhenExists(TableLocator);

        public IWebElement WaitForHeaderDisplayed() => WebDriverFactory.Driver.GetWebElementWhenExists(ColumnsLocator);
    }
}
