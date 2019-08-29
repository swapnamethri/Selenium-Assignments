using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace Aug_27_work
{
    class NUnitTCVerifyCleartripMinPrice
    {
        ChromeDriver driver;


        [OneTimeSetUp]
        public void OpenbrowserInputFields()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--disable-notifications");
            driver = new ChromeDriver(options);
            //Maximize Browser
            driver.Manage().Window.Maximize();
            //Navigate to Web page
            driver.Url = "https://cleartrip.com/";
            //Enter source
            driver.FindElementById("FromTag").SendKeys("BOM");
            //Enter Destination
            driver.FindElementById("ToTag").SendKeys("DEL");
            //Select Date 
            driver.FindElementById("DepartDate").Click();

            IWebElement comingmonth = driver.FindElementByCssSelector("#ui-datepicker-div > div.monthBlock.last");

            IList<IWebElement> columns = comingmonth.FindElements(By.TagName("td"));

            foreach (IWebElement t in columns)
            {
                if (t.Text.Equals("22"))
                {
                    t.Click();
                    break;
                }
            }
            //Click Search
            driver.FindElementById("SearchBtn").Click();
        }

        [Test]
        public void VerifySource()
        {
            //bool Fromfield = driver.FindElementById("FromTag").Selected;
            //Assert.IsTrue(Fromfield);
            string expectedsource = "Mumbai,IN-Chatrapati Shivaji Airport(BOM)";
            string actualsource = driver.FindElementById("FromTag").Text;
            Assert.AreEqual(expectedsource, actualsource);
        }
        [Test]

        public void VerifyDestination()
        {
            bool Fromfield = driver.FindElementById("ToTag").Selected;
            Assert.IsTrue(Fromfield);
            string expectedsource = "New Delhi, IN - Indira Gandhi Airport (DEL)";
            string actualsource = driver.FindElementById("ToTag").Text;
            Assert.AreEqual(expectedsource, actualsource);
        }

        [OneTimeTearDown]

        public void ClosebrowserPrintPrice()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Id("BaggageBundlingTemplate")));

            string minprice = driver.FindElementById("BaggageBundlingTemplate").Text;
            string flight = driver.FindElementByCssSelector("#flightForm > section.resultsContainer > div.row.legsContainer > div > nav > ul > li.listItem.showTabs.nonBundled > table > tbody.segment > tr:nth-child(1) > th.vendor.count1 > small:nth-child(2)").Text;

            Console.WriteLine("Minimum price is  = " + minprice);
            Console.WriteLine("Airlines = " + flight);
            Console.Read();
         
        }
        

    }
}
