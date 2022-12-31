using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoTestingPageObject.Steps;
using AutoTestingPageObject.Pages;
using NUnit.Framework.Internal;
using OpenQA.Selenium.DevTools.V105.Debugger;

namespace AutoTestingPageObject.Tests
{
    [TestFixture]
    public class Tests
    {
        private Steps.Steps steps;
        private readonly String searchTextTest1 = "лопата";
        private readonly String searchTextTest2 = "книга";

        public Tests()
        {
            steps = new Steps.Steps();
        }

        [SetUp]
        public void Init()
        {
            steps.InitBrowser();
        }

        [TearDown]
        public void Cleanup()
        {
            steps.CloseBrowser();
        }

        [Test]
        public void Test1()
        {
            steps.OpenOtherPage("https://www.ebay.com/");
            steps.FillingBar(MainPage.searchBar, searchTextTest1);
            steps.ButtonClick(MainPage.searchButton);
            Assert.That(Steps.Steps.driver.Title, Is.EqualTo(searchTextTest1 + " for sale | eBay"));
        }

        [Test]
        public void Test2()
        {
            steps.OpenOtherPage("https://www.ebay.com/");
            steps.ButtonClick(MainPage.extendedSearchButton);
            steps.FillingBar(ExtendedSearchPage.searchBar, searchTextTest1);
            steps.ButtonClick(ExtendedSearchPage.searchButton);
            Assert.That(Steps.Steps.driver.Title, Is.EqualTo(searchTextTest1 + " for sale | eBay"));
        }

        [Test]
        public void Test3()
        {
            steps.OpenOtherPage("https://cart.payments.ebay.com/");
            steps.FillingBar(TrackingListPage.searchBar, searchTextTest2);
            steps.ButtonClick(TrackingListPage.bar);
            steps.ComparisonStrings(searchTextTest2, Steps.Steps.driver.Title);
        }

        [Test]
        public void Test4()
        {
            steps.OpenOtherPage("https://cart.payments.ebay.com/");
            steps.FillingBar(ExtendedSearchPage.searchBar, searchTextTest1);
            steps.ButtonClick(ExtendedSearchPage.searchButton);
            steps.ComparisonStrings(Steps.Steps.driver.Title, searchTextTest1);
        }

        [Test]
        public void Test5()
        {
            steps.OpenOtherPage("https://www.ebay.com/sch/i.html?_from=R40&_trksid=p2380057.m570.l1313&_nkw=%D0%BB%D0%BE%D0%BF%D0%B0%D1%82%D0%B0&_sacat=0");
            steps.ClearField(Basket.product);
            steps.FillingBar(Basket.mainList, searchTextTest1);
            steps.ButtonClick(Basket.cleaning);
            steps.ComparisonStrings(Steps.Steps.driver.Title, searchTextTest1);
        }

        [Test]
        public void Test6()
        {
            steps.OpenOtherPage("https://www.ebay.com/sch/i.html?_from=R40&_trksid=p2380057.m570.l1313&_nkw=%D0%BB%D0%BE%D0%BF%D0%B0%D1%82%D0%B0&_sacat=0");
            string beforeTesting = Steps.Steps.driver.Title;

            steps.ButtonClick(MainPage.extendedSearchButton);
            steps.FillingBar(Basket.cleaning, searchTextTest2);
            steps.ButtonClick(Basket.product);
            Assert.That(beforeTesting, Is.EqualTo(Steps.Steps.driver.Title));
        }

        [Test]
        public void Test7()
        {
            steps.OpenOtherPage("https://www.ebay.com/mye/myebay/summary");
            steps.ButtonClick(MainPage.extendedSearchButton);
            steps.FillingBar(ExtendedSearchPage.searchBar, searchTextTest1);
            steps.ButtonClick(ExtendedSearchPage.searchButton);
            steps.ComparisonStrings(Steps.Steps.driver.Title, searchTextTest1);
        }

        [Test]
        public void Test8()
        {
            steps.OpenOtherPage("https://www.ebay.com/sch/i.html?_from=R40&_trksid=p2380057.m570.l1313&_nkw=%D0%BB%D0%BE%D0%BF%D0%B0%D1%82%D0%B0&_sacat=0");
            steps.ClearField(Basket.product);
            steps.FillingBar(Basket.mainList, searchTextTest1);
            steps.ButtonClick(Basket.cleaning);
            steps.ComparisonStrings(Steps.Steps.driver.Title, searchTextTest1);
        }
    }
}
