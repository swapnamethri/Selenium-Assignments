using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Aug_27_work.com.Shopclues.pages
{
    class Searchresults
    {
        [FindsBy(How = How.CssSelector, Using = "#product_list > div:nth-child(3) > div:nth-child(1) > a > h2")]
        private IWebElement searchbox;
    }
}
//All Correct