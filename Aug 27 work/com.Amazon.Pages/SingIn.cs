using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Aug_27_work.com.Amazon.Pages
{
    class SingIn
    {

        [FindsBy(How = How.Id, Using = "ap_email")]
        private IWebElement Email;

        [FindsBy(How = How.Id, Using = "continue")]
        private IWebElement contin;
    }
}
