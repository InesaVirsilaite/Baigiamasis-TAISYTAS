

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using BaigiamasisDarbasInesa.Page;
using BaigiamasisDarbasInesa.Drivers;

namespace BaigiamasisDarbasInesa.Test
{
    public class NestumoSkaiciuoleTest 
    {
        private static IWebDriver driver;
        private static NestumoSkaiciuolePage page;

        [OneTimeSetUp]
            public static void OneTimeSetup()
            {
                driver = CustomDrivers.GetChrome();
                driver.Url = "https://www.manodaktaras.lt/skaiciuokles/nestumas";

                driver.FindElement(By.CssSelector("body > div.fc-consent-root > div.fc-dialog-container > div.fc-dialog.fc-choice-dialog > div.fc-footer-buttons-container > div.fc-footer-buttons > button.fc-button.fc-cta-consent.fc-primary-button > p")).Click();
                page = new NestumoSkaiciuolePage(driver);
            }
        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
            page.CloseBrowser();
        }
      
        [Test]
        public static void TestNestumoSkaiciuokle20220401_27()
        {
            page.InputToFieldPaskutineMenesiniuDiena();
            page.ClickMenesiniuCikloTrukme();
            page.ClickButtonSkaiciuoti();
            page.VerifyResultGimdymoData();
        }










    }
}
