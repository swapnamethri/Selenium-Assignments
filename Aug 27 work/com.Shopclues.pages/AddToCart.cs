using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Aug_27_work.com.Shopclues.pages
{
    class AddToCart
    {
        [FindsBy(How = How.Id, Using = "add_cart")]
        private IWebElement Addtocart;

        //I missed the Mouse Hover - don't know how to write using FindsBy 
       
        [FindsBy(How = How.LinkText, Using = "PLACE ORDER")]
        private IWebElement order;
    }
}
