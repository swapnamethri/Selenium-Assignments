using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace Aug_27_work
{
    class FBInvalidUsernamePassword
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
            driver.Url = "https://www.facebook.com/";
        }
        [Test]
        public void VerifyErrorMessage()
        {
            driver.FindElementById("email").SendKeys("user@gmal.com");
            driver.FindElementById("pass").SendKeys("testing123");
            driver.FindElementById("u_0_2").Click();
            string expectederrormsg = "The password you’ve entered is incorrect. Forgot Password?";
            string actualerrormsg = driver.FindElementByCssSelector("#globalContainer > div.uiContextualLayerPositioner._572t.uiLayer > div > div > div").Text;
        }

        [OneTimeTearDown]
        public void Closebrowser()
        {
            driver.Quit();

        }




    }
}
