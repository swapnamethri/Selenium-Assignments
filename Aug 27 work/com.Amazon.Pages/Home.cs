using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Aug_27_work.com.Amazon.Pages
{
    class Home
    {
        [FindsBy(How = How.Id, Using = "twotabsearchtextbox")]
        private IWebElement searchbox;

        [FindsBy(How = How.CssSelector, Using = "#nav-search > form > div.nav-right > div > input")]
        private IWebElement searchicon;
    }
}
