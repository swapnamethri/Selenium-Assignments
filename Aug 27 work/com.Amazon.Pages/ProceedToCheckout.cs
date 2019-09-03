using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Aug_27_work.com.Amazon.Pages
{
    class ProceedToCheckout
    {
        [FindsBy(How = How.LinkText, Using = "Procees to checkout(1 item)")]
        private IWebElement Addtocart;
    }
}
