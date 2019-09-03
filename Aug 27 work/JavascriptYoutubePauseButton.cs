using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Aug_27_work
{
    class JavascriptYoutubePauseButton
    {
        ChromeDriver driver;

        [OneTimeSetUp]
        public void Openbrowser()
        {
            //Open Browser
            driver = new ChromeDriver();
            //Maximize Browser
            driver.Manage().Window.Maximize();
            //Navigate to Web page
            driver.Url = "https://www.youtube.com/watch?v=qoDSxpm5Slk";
        }

        [Test]
        public void ClickpausebuttonusingJS()
        {
          IWebElement pause  = driver.FindElementByCssSelector("#movie_player > div.ytp-chrome-bottom > div.ytp-chrome-controls > div.ytp-left-controls > button");
          IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
          js.ExecuteScript("arguments[0].click()",pause);
        }
        [OneTimeTearDown]
        public void Closebrowser()
        {
           driver.Quit();

        }
    }
}
