using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Aug_27_work.com.Shopclues.pages
{
    class Search
    {
        [FindsBy(How = How.Id, Using = "autocomplete")]
        private IWebElement searchbox;

        [FindsBy(How = How.LinkText, Using = "Search")]
        private IWebElement searchicon;
    }
}
