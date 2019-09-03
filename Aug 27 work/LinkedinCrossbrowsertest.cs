using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace Aug_27_work
{
    class LinkedinCrossbrowsertest
    {
        IWebDriver driver;

        public static IEnumerable<String> Browsers()
        {
            String[] browsers = { "Chrome", "Firefox",};
            foreach (string b in browsers)
            {
                yield return b;
            }
        }
        
        [TestCaseSource("Browsers")]
        public void OpenBrowser(string browser)
        {

            //Open Browser
            if (browser.Equals("Chrome"))
            {
                driver = new ChromeDriver();
            }
            else if (browser.Equals("Firefox"))
            {
                driver = new FirefoxDriver();
            }

            //Maximize Browser
            driver.Manage().Window.Maximize();
            //Navigate to Web page
            driver.Url = "https://www.linkedin.com/";
        }
        [Test]
        public void VerifyMessagedisplayed()
        {
          bool Messagestatus  = driver.FindElement(By.CssSelector("body > main > section.section.section--hero > div > h1")).Displayed;
            Assert.IsTrue(Messagestatus); 
            
        }

        [OneTimeTearDown]
        public void Closebrowser()
        {
            driver.Quit();

        }
    }
}
