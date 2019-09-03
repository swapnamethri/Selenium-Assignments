using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Aug_27_work.com.Amazon.Pages
{
    class AddToCart
    {
        [FindsBy(How = How.Id, Using = "add-to-cart-button")]
        private IWebElement Addtocart;

    }
}
