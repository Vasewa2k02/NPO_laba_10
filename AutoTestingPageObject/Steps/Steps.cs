using AutoTestingPageObject.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTestingPageObject.Steps
{
    public class Steps
    {
        public static IWebDriver driver;

        public Steps()
        {
            driver = new ChromeDriver();
        }

        public void InitBrowser()
        {
            driver = Driver.DriverInstance.GetInstance();
        }

        public void OpenOtherPage(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void CloseBrowser()
        {
            Driver.DriverInstance.CloseBrowser();
        }

        public void ButtonClick(By item)
        {
            driver.FindElement(item).Click();
        }

        public void FillingBar(By item, string text)
        {
            driver.FindElement(item).Clear();
            driver.FindElement(item).SendKeys(text);
        }

        public void ClearField(By item)
        {
            driver.FindElement(item).Clear();
        }

        public void ComparisonStrings(string str1, string str2)
        {
            Assert.That(str1, Is.EqualTo(str2));
        }
    }
}
