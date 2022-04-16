
using BaigiamasisDarbasInesa.Drivers;
using BaigiamasisDarbasInesa.Page;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace BaigiamasisDarbasInesa.Test
{
     public class PaslaugosTest
    {
        private static IWebDriver driver;
        private static PaslaugosPage page;


        [OneTimeSetUp]
        public static void OneTimeSetup()
        {
            driver = CustomDrivers.GetChrome();
            driver.Url = "https://www.manodaktaras.lt/";
            
            driver.FindElement(By.CssSelector("body > div.fc-consent-root > div.fc-dialog-container > div.fc-dialog.fc-choice-dialog > div.fc-footer-buttons-container > div.fc-footer-buttons > button.fc-button.fc-cta-consent.fc-primary-button > p")).Click();
            page = new PaslaugosPage(driver);
        }
        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
            page.CloseBrowser();
        }
        [Test]  
        public static void TestPaslaugos()
        {
            page.ClickButtonPaslaugos();
            page.ClickbuttonVisiMiestai();
            page.ClickselectVilnius();
            page.FillpaslaugaInputField();
            page.ClickbuttonSearch();
            page.ReceivedGerovesKlinika();
        }
     }
}
