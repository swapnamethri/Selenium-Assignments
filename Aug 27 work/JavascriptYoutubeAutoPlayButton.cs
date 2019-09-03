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
    class JavascriptYoutubeAutoPlayButton
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
        public void ToggelAutoPlayjavascript()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("toggleButton")));
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("document.getElementById('toggleButton').click()");
        }
        [OneTimeTearDown]
        public void Closebrowser()
        {
            driver.Quit();

        }
    }
}
