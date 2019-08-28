using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace Aug_27_work
{
    class barnesnobleGamesCollictable
    {
        static void Main(string[] args)
        {

            //1) Open the browser
            ChromeDriver driver = new ChromeDriver();
            //2) Maximize the browser
            driver.Manage().Window.Maximize();
            //3) Navigate to the application
            driver.Url = "https://www.barnesandnoble.com/";
            // Mouse Hover on Games & Collectibles
            IWebElement GC = driver.FindElementByLinkText("Games & Collectibles");
            Actions action = new Actions(driver);
            action.MoveToElement(GC).Perform();
            //Cick on "BestSeller"
            driver.FindElementByLinkText("Bestsellers").Click();

        }
    }
}
//Perfect