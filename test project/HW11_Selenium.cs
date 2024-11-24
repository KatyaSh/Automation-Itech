using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;

namespace TestProject
{
    public class HW11_Selenium
    {
        private IWebDriver? driver;
        private IJavaScriptExecutor? javascriptExecutor;
        private WebDriverWait? webDriverWait;
        private HttpClient? client;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver?.Manage().Window.Maximize();
            webDriverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(120));
            javascriptExecutor = (IJavaScriptExecutor)driver;
            client = new HttpClient();
        }

        [TearDown]
        public void TearDown()
        {
            driver?.Close();
            driver?.Quit();
        }

        private void ScrollToElement(IWebElement element)
        {
            javascriptExecutor?.ExecuteScript("arguments[0].scrollIntoView()", element);
        }

        private IWebElement WaitForElement(By locator)
        {
            return webDriverWait?.Until(drv => drv.FindElement(by: locator))!;
        }

        [Test]
        public void CheckCheckbox()
        {
            driver?.Navigate().GoToUrl("https://demoqa.com/checkbox");
            var checkbox = WaitForElement(By.XPath("//span[contains(@class,'rct-checkbox')]/*[local-name()='svg']"));

            Assert.That(checkbox?.Displayed, Is.True, "Чекбокс не отображается!");
            Assert.That(checkbox?.Enabled, Is.True, "Чекбокс не активен!");
            Assert.That(checkbox?.GetAttribute("class").Contains("-uncheck"), Is.True, "Чекбокс уже выбран!");

            checkbox.Click();

            checkbox = WaitForElement(By.XPath("//span[contains(@class,'rct-checkbox')]/*[local-name()='svg']"));
            Assert.That(checkbox.GetAttribute("class").Contains("-check"), Is.True, "Чекбокс не выбран!");

            var resultTextElement = WaitForElement(By.XPath("//div[@id=\"result\"]/span[1]"));
            Assert.That(resultTextElement.Text, Is.EqualTo("You have selected :"), "Ожидаемый текст по клику чекбокса не отображается.");
        }

        [Test]
        public void CheckRadioButton()
        {
            driver?.Navigate().GoToUrl("https://demoqa.com/radio-button");

            var yesRadioButton = WaitForElement(By.Id("yesRadio"));
            Assert.That(yesRadioButton?.Selected, Is.False, "Кнопка 'Yes' не выбрана по умолчанию.");

            var yesLabel = WaitForElement(By.XPath("//*[@id=\"yesRadio\"]//following-sibling::label"));
            Assert.That(yesLabel.Text, Is.EqualTo("Yes"), "Текст радиокнопки 'Yes' неверен.");

            ScrollToElement(yesLabel);
            yesLabel.Click();

            var resultTextElement = WaitForElement(By.XPath("//*[@id=\"yesRadio\"]//following::p"));
            Assert.Multiple(() =>
            {
                Assert.That(yesRadioButton.Selected, Is.True, "Кнопка 'Yes' должна быть выбрана!");
                Assert.That(resultTextElement.Text, Is.EqualTo("You have selected Yes"), "Текст по клику radiobutton неверен.");
                Assert.That(resultTextElement.Text.Contains(yesLabel.Text), Is.True, "Ожидаемый текст отсутствует.");
            });
        }

        [Test]
        public void CheckWebTable()
        {
            driver?.Navigate().GoToUrl("https://demoqa.com/webtables");

            var table = WaitForElement(By.XPath("//div[contains(@class,'rt-table')]"));
            ScrollToElement(table);

            Assert.That(table.Displayed, Is.True, "Таблица не отображается");

            var rows = driver?.FindElements(By.XPath("//div[contains(@role,'rowgroup')]"));
            var columns = driver?.FindElements(By.XPath("//div[contains(@role,'columnheader')]"));

            Assert.Multiple(() =>
            {
                Assert.That(rows?.Count > 0, Is.True, "Таблица не содержит строк");
                Assert.That(columns?.Count > 0, Is.True, "Таблица не содержит колонок");
            });

            var firstHeader = WaitForElement(By.XPath("//div[contains(@role,'columnheader')][1]"));
            Assert.That(firstHeader.GetAttribute("class").Contains("-sort-desc"), Is.False, "Сортировка по убыванию включена.");

            List<string> columnValuesBeforeSorting = driver?
                .FindElements(By.XPath("//div[contains(@role,'rowgroup')]//div[contains(@role,'gridcell')][1]"))
                .Select(cell => cell.Text)
                .Where(text => !string.IsNullOrWhiteSpace(text))
                .ToList();

            firstHeader.Click();

            Assert.That(firstHeader.GetAttribute("class").Contains("-sort-asc"), Is.True, "Сортировка по возрастанию не включена.");

            List<string> columnValuesAfterSorting = driver?
                .FindElements(By.XPath("//div[contains(@role,'rowgroup')]//div[contains(@role,'gridcell')][1]"))
                .Select(cell => cell.Text)
                .Where(text => !string.IsNullOrWhiteSpace(text))
                .ToList();

            var sortedValues = new List<string>(columnValuesBeforeSorting);
            sortedValues.Sort();

            Assert.That(columnValuesAfterSorting.SequenceEqual(sortedValues), Is.True, "Таблица не отсортирована по возрастанию.");
        }

        [Test]
        public void CheckButtons()
        {
            driver?.Navigate().GoToUrl("https://demoqa.com/buttons");

            var actions = new Actions(driver);

            var doubleClickBtn = WaitForElement(By.Id("doubleClickBtn"));
            ScrollToElement(doubleClickBtn);
            actions.DoubleClick(doubleClickBtn).Perform();
            Assert.That(WaitForElement(By.Id("doubleClickMessage")).Text, Is.EqualTo("You have done a double click"), "Ошибка в тексте двойного клика.");

            var rightClickBtn = WaitForElement(By.Id("rightClickBtn"));
            ScrollToElement(rightClickBtn);
            actions.ContextClick(rightClickBtn).Perform();
            Assert.That(WaitForElement(By.Id("rightClickMessage")).Text, Is.EqualTo("You have done a right click"), "Ошибка в тексте правого клика.");

            var simpleBtn = WaitForElement(By.XPath("//button[text()='Click Me']"));
            actions.Click(simpleBtn).Perform();
            Assert.That(WaitForElement(By.Id("dynamicClickMessage")).Text, Is.EqualTo("You have done a dynamic click"), "Ошибка в тексте клика.");
        }

        [Test]
        public void CheckLinks()
        {
            driver?.Navigate().GoToUrl("https://demoqa.com/links");

            var simpleLink = WaitForElement(By.Id("simpleLink"));
            ScrollToElement(simpleLink);

            var tabsBeforeClick = driver?.WindowHandles;
            simpleLink.Click();

            var tabsAfterClick = driver?.WindowHandles;
            Assert.That(tabsAfterClick?.Count > tabsBeforeClick?.Count, Is.True, "Новая вкладка не открылась.");

            driver?.SwitchTo().Window(tabsAfterClick?[1]);
            Assert.That(driver?.Url, Is.EqualTo("https://demoqa.com/"), "Неверный URL в новой вкладке.");

            driver?.Close();
            driver?.SwitchTo().Window(tabsBeforeClick?[0]);
            var createdLink = WaitForElement(By.Id("created"));
            ScrollToElement(createdLink);
            createdLink.Click();

            var linkResponse = WaitForElement(By.LinkText("Created"));
            Assert.That(linkResponse.Text, Is.EqualTo("Created"), "Текст ссылки неверен.");
        }

        [Test]
        public async Task CheckBrokenImageAsync()
        {
            driver?.Navigate().GoToUrl("https://demoqa.com/broken");

            var brokenImage = WaitForElement(By.XPath("//p[text()='Broken image']//following-sibling::img"));
            var src = brokenImage.GetAttribute("src");
            Assert.That(src, Is.Not.Null, "Атрибут src изображения не задан.");

            var baseUrl = driver.Url;
            var absoluteUri = new Uri(new Uri(baseUrl), src).ToString();

            HttpResponseMessage response = await client?.GetAsync(absoluteUri);
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK), "Неверный статус код ответа сервера.");

            var contentType = response.Content.Headers.ContentType?.ToString();
            Assert.Multiple(() =>
            {
                Assert.That(contentType, Is.Not.Null, "Content-Type отсутствует в ответе сервера.");
                Assert.That(contentType.StartsWith("image/"), Is.True, $"Неверный Content-Type: {contentType}. Ожидается image.");
            });
        }


        [Test]
        public void CheckUploadAndDownload()
        {
            driver?.Navigate().GoToUrl("https://demoqa.com/upload-download");

            var uploadButton = WaitForElement(By.Id("uploadFile"));
            ScrollToElement(uploadButton);
            Assert.That(uploadButton.Displayed, Is.True, "Кнопка загрузки файла (Upload) не отображается.");

            string projectDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
            string fileName = "testfile.txt";
            string filePath = Path.Combine(projectDirectory, "TestFiles", fileName);

            uploadButton.SendKeys(filePath);
            var uploadedFilePath = WaitForElement(By.XPath("//p[@id='uploadedFilePath']")).Text;
            Assert.That(uploadedFilePath.Contains(fileName), Is.True, "Файл не был загружен.");

            var downloadButton = WaitForElement(By.Id("downloadButton"));
            ScrollToElement(downloadButton);
            Assert.That(downloadButton.Displayed, Is.True, "Кнопка скачивания файла (Download) не отображается.");

            downloadButton.Click();
            string downloadPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
            string expectedFileName = "sampleFile.jpeg";
            string fullFilePath = Path.Combine(downloadPath, expectedFileName);
            Assert.That(File.Exists(fullFilePath), Is.True, $"Файл {expectedFileName} не найден в папке загрузок.");
        }

        [Test]
        public void CheckDynamicProperties()
        {
            driver?.Navigate().GoToUrl("https://demoqa.com/dynamic-properties");
            var button = WaitForElement(By.XPath("//button[@id='visibleAfter']"));
            webDriverWait?.Until(drv => button.Displayed);
            ScrollToElement(button);
            Assert.That(button.Displayed, Is.True, "Кнопка visibleAfterButton не отображается.");

            driver.Navigate().Refresh();

            var ChangerButton = WaitForElement(By.Id("colorChange"));
            webDriverWait?.Until(drv => ChangerButton.Displayed);
            ScrollToElement(ChangerButton);
            var colorChangerButton1 = ChangerButton.GetCssValue("color");
            var colorAfterChange = WaitForElement(By.XPath("//button[contains(@class,'text-danger')]")).GetCssValue("color");
            Assert.That(colorAfterChange.Equals(colorChangerButton1), Is.False, $" цвет кнопки до изменения: {colorChangerButton1}, цвет кнопки после изменения: {colorAfterChange}");
        }
    }
}
