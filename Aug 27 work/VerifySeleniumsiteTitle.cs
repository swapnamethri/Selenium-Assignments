using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace Aug_27_work
{
    class VerifySeleniumsiteTitle
    {
        ChromeDriver driver;


        [OneTimeSetUp]
        public void Openbrowser()
        {

            driver = new ChromeDriver();
            //Maximize Browser
            driver.Manage().Window.Maximize();
            //Navigate to Web page
            driver.Url = "https://www.seleniumhq.org/";
        }

        [Test]

        public void VerifyTitle()
        {
            string expectedTitle = "Selenium - Web Browser Automation";
            string actualTitle = driver.Title;
            Assert.AreEqual(expectedTitle, actualTitle);

        }
        [OneTimeTearDown]
        public void Closebrowser()
        {
            driver.Close();
        }

    }

}
