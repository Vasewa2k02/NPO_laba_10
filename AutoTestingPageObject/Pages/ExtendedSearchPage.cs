using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTestingPageObject.Pages
{
    public class ExtendedSearchPage
    {
        public static readonly By searchBar = By.Name("_nkw");
        public static readonly By searchButton = By.ClassName("btn-prim");
    }
}
