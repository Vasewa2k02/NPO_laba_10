using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System.Text.RegularExpressions;
using System.Collections.ObjectModel;

namespace AutoTesting
{
    public class Browser
    {
        public static IWebDriver driver;

        public Browser(string url)
        {
            driver = new ChromeDriver();
            OpenOtherPage(url);
        }

        public void OpenOtherPage(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void CloseBrowser()
        {
            driver.Quit();
        }

        public static void ButtonClick(By item)
        {
            driver.FindElement(item).Click();
        }

        public static void FillingBar(By item, string text)
        {
            driver.FindElement(item).Clear();
            driver.FindElement(item).SendKeys(text);
        }

        public class MainPage
        {
            private static readonly String searchText = "лопата";

            public class MainBar
            {
                private static readonly By searchBar = By.Name("_nkw");
                private static readonly By searchButton = By.Id("gh-btn");

                public class Test
                {
                    Browser browser = new Browser("https://www.ebay.com/");

                    [Test]
                    public void Test_1()
                    {
                        FillingBar(searchBar, searchText);
                        ButtonClick(searchButton);
                        Assert.That(driver.Title, Is.EqualTo(searchText + " for sale | eBay"));
                    }

                    [TearDown]
                    public void TearDown()
                    {
                        browser.CloseBrowser();
                    }
                }

            }

            public class ExtendedBar
            {
                private static readonly By extendedSearchButton = By.Id("gh-as-a");
                private static readonly By searchBar = By.Name("_nkw");
                private static readonly By searchButton = By.ClassName("btn-prim");

                public class Test
                {
                    Browser browser = new Browser("https://www.ebay.com/");

                    [Test]
                    public void Test_1()
                    {
                        ButtonClick(extendedSearchButton);
                        FillingBar(searchBar, searchText);
                        ButtonClick(searchButton);
                        Assert.That(driver.Title, Is.EqualTo(searchText + " for sale | eBay"));
                    }

                    [TearDown]
                    public void TearDown()
                    {
                        browser.CloseBrowser();
                    }
                }
            }
        }
    }
}