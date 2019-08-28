using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;



namespace Aug_27_work
{
    
    class WhitecircleschoolAlertBox
        {
        static ChromeDriver driver;
        public static bool Alertbox()
            {
                bool Alertbox = true;

                try
                {
                    driver.SwitchTo().Alert();
                }

                catch (Exception e)
                {
                    Alertbox = false;
                }
                return Alertbox;
            }
            static void Main(string[] args)
            {
                //Open Browser
                driver = new ChromeDriver();
                //Maximize Browser
                driver.Manage().Window.Maximize();
                //Navigate to Web page
                driver.Url = "http://whitecircleschool.com/alertboxdemo/";
                //Click on "TRY IT"
                driver.FindElementByCssSelector("body > div.elementor.elementor-599.elementor-bc-flex-widget > div > div > section.elementor-element.elementor-element-9860042.elementor-section-boxed.elementor-section-height-default.elementor-section-height-default.elementor-section.elementor-top-section > div > div > div > div > div > div > div > button").Click();
                //Close the Alertbox , if present
                if (Alertbox())
                {
                    driver.SwitchTo().Alert().Accept();
                }

            }
        }
    }
   //Perfect