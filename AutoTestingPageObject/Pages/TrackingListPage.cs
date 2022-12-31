using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTestingPageObject.Pages
{
    public class TrackingListPage
    {
        public static readonly By bar = By.XPath("/html/body/div[8]/div[4]/div[2]/div[1]/div[2]/ul/li[1]/div/div[2]/a");
        public static readonly By searchBar = By.XPath("/html/body/div[8]/div[4]/div[2]/div[1]/div[2]/ul/li[1]/div/div[2]/a");
    }
}
