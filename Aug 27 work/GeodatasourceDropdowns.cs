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
    class GeodatasourceDropdowns
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
            driver.Url = "https://www.geodatasource.com/software/world-major-cities-drop-down-list-source-codes";
        }
        [Test ,Order(1)]
        public void CountryDropdown()
        {
            IWebElement Country = driver.FindElementById("countryCode");
            SelectElement Select = new SelectElement(Country);
            Select.SelectByText("Australia");
        }
        [Test, Order(2)]
        public void RegionDropdown()
        {
            IWebElement Region = driver.FindElementById("regionName");
            SelectElement Select1 = new SelectElement(Region);
            Select1.SelectByText("Western Australia");
        }
        [Test, Order(3)]
        public void CitynameDropdown()
        {
            IWebElement City = driver.FindElementById("cityName");
            SelectElement Select2 = new SelectElement(City);
            Select2.SelectByText(" Perth");
        }

        [OneTimeTearDown]
        public void Closebrowser()
        {
            driver.Quit();

        }

    }
    
}
