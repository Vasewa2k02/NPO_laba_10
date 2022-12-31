using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTestingPageObject.Pages
{
    public class Basket
    {
        public static readonly By product = By.XPath("/html/body/div[5]/div[2]/div/div[2]/div[1]/div[1]/ul/li/div/div/div/div[1]/div/div[2]/div/h3/span/a");
        public static readonly By mainList = By.XPath("/html/body/div[5]/div[2]/div/div[2]/div[1]/div[1]/ul/li/div/div/div/div[1]/div/div[2]/div/h3/span/a");
        public static readonly By cleaning = By.XPath("/html/body/div[5]/div[2]/div/div[2]/div[1]/div[1]/ul/li/div/div/div/div[1]/div/div[2]/div/h3/span/a");
    }
}
