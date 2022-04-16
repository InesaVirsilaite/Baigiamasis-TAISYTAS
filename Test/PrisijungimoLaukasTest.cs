

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using BaigiamasisDarbasInesa.Page;
using BaigiamasisDarbasInesa.Drivers;

namespace BaigiamasisDarbasInesa.Test
{
    public class PrisijungimoLaukasTest
    {
        private static IWebDriver driver;
        private static PrisijungimoLaukasPage page;
        
        [OneTimeSetUp]
        public static void OneTimeSetup()
        {
            driver = CustomDrivers.GetChrome();
            driver.Url = "https://www.manodaktaras.lt/registracija";
           
            driver.FindElement(By.CssSelector("body > div.fc-consent-root > div.fc-dialog-container > div.fc-dialog.fc-choice-dialog > div.fc-footer-buttons-container > div.fc-footer-buttons > button.fc-button.fc-cta-consent.fc-primary-button > p")).Click();
            page = new PrisijungimoLaukasPage(driver);
        }
        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
            page.CloseBrowser();
        }

        [TestCase("Jonas", "Jonaitis", "Slaptažodį turi sudaryti bent 8 simboliai", TestName = "Jonas Jonaitis")]
        [TestCase("Stasys", "Stasytis", "Slaptažodį turi sudaryti bent 8 simboliai", TestName = "Stasys Stasytis")]
        [TestCase("Tomas", "Tomaitis", "Slaptažodį turi sudaryti bent 8 simboliai", TestName = "Tomas Tomaitis")]
       
        [Test]
        public static void TestPrisijungimoLaukai(string asmensVardas, string asmensPavarde, string gautasPranesimas)
        {
            page.ClickOnVardas(asmensVardas);
            page.ClickOnPavarde(asmensPavarde);
            page.ClickOnbuttonSukurtiPaskyra();
            page.VerifyReceivedMessage(gautasPranesimas);
        }



    }
}