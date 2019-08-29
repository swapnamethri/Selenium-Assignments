using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace Aug_27_work
{
    class SeleniumTitleDownload
    {
        ChromeDriver driver;


        [OneTimeSetUp]
        public void Openbrowser()
        {
          
           driver = new ChromeDriver();
            //Maximize Browser
            driver.Manage().Window.Maximize();
            //Navigate to Web page
            driver.Url = "https://www.seleniumhq.org/download";
        }

        [Test]

        public void VerifyTitle()
        {
            string expectedTitle = "Downloads";
            string actualTitle = driver.Title;
            Assert.AreEqual(expectedTitle, actualTitle);

        }

        public void VerifyText()
        {
            string expectedtext = "Selenium Client & WebDriver Language Bindings";
            string actualtext = driver.FindElementByCssSelector("#mainContent > a:nth-child(11) > h3").Text;
            Assert.AreEqual(expectedtext, actualtext);
        }

        [OneTimeTearDown]

        public void Closebrowser()
        {
            driver.Close();
        }
    }
}
