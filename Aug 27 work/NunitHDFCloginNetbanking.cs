using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace Aug_27_work
{
    class NunitHDFCloginNetbanking
    {

        ChromeDriver driver;

        [OneTimeSetUp]
        public void Openbrowser()
        {
            //Open Browser
            ChromeDriver driver = new ChromeDriver();
            //Maximize Browser
            driver.Manage().Window.Maximize();
            //Navigate to Web page
            driver.Url = "https://www.hdfcbank.com/";
            //Close the Advertisement
            
        }
        [Test]
        public void LoginNetBanking()
        {
            driver.FindElementByCssSelector("#parentdiv > img").Click();
            //IWebElement image = driver.FindElementByCssSelector("#parentdiv > img");
            //Actions action = new Actions(driver);
            //action.Click(image).Perform();
            driver.FindElementByLinkText("LOGIN").Click();

            //Click on Continue to netbanking
            ArrayList windows = new ArrayList(driver.WindowHandles);
            driver.SwitchTo().Window(windows[1].ToString());

            //Click on NetBanking
            driver.FindElementByLinkText("CONTINUE TO NETBANKING");

            //Click on 1st "Know More" link
            driver.FindElementByLinkText("Know More").Click();

            //Click on Continue new window
            ArrayList windows1 = new ArrayList(driver.WindowHandles);
            driver.SwitchTo().Window(windows[1].ToString());

            //4) Hover over  on 'Borrow'(couldn't fine "Applynow" on the 3rd window , used Borrow instead 
            IWebElement Borrow= driver.FindElementByCssSelector("#main > div > div:nth-child(3) > div.bp-widget-body.ng-scope > div > div > div > div > div > div > div > div:nth-child(1) > div.navbar-collapse.ng-scope.collapse > ul > li:nth-child(5) > a > span.borrow-icon-large-off.menu-icon");
            Actions actions = new Actions(driver);
            actions.MoveToElement(Borrow).Perform();

            //Click on "Personal Loan"
            driver.FindElementByCssSelector("#main > div > div:nth-child(3) > div.bp-widget-body.ng-scope > div > div > div > div > div > div > div > div:nth-child(1) > div.navbar-collapse.ng-scope.collapse > ul > li:nth-child(5) > ul > li.level-2.sub-parent.dyna-width-5.active > ul > li:nth-child(2) > a > span").Click();

            //Click "APPLY ONLINE"
            driver.FindElementByLinkText("APPLY ONLINE)").Click();

            //ENter the Mobile number 9999988888
            driver.FindElementById("txtmissing_18").SendKeys("9999988888");
        }

        [OneTimeTearDown]
        public void Closebrowser()
        {
            driver.Quit();

        }
    }
}
