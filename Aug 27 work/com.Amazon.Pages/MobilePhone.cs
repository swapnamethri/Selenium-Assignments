using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Aug_27_work.com.Amazon.Pages
{
    class MobilePhone
    {

        [FindsBy(How = How .XPath, Using = "(//span[contains(@class,'a-size-medium a-color-base a-text-normal')])[1]")]
        private IWebElement Selectphone;

    }
}
