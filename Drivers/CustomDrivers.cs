

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace BaigiamasisDarbasInesa.Drivers
{
    
    public class CustomDrivers
    {
        public static IWebDriver GetChrome()
        {
            return GetDriver("chrome");

        }
        private static IWebDriver GetDriver(string webdriver)
        {
            IWebDriver driver;
            switch(webdriver)
            {
                case "chrome":
                  driver = new ChromeDriver();
                  break;
                default:
                    driver = new ChromeDriver();
                    break;
                   
            }
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            return driver;
        }

    }
}
