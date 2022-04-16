using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using BaigiamasisDarbasInesa.Page;
using BaigiamasisDarbasInesa.Drivers;

namespace BaigiamasisDarbasInesa.Test
{
    public class SveikatosSimptomaiTest
    {
        private static IWebDriver driver;
        private static SveikatosSimptomaiPage page;


        [OneTimeSetUp]
        public static void OneTimeSetup()
        {
            driver = CustomDrivers.GetChrome();
            driver.Url = "https://www.manodaktaras.lt/skaiciuokles/sveikatos-testas";

            driver.FindElement(By.CssSelector("body > div.fc-consent-root > div.fc-dialog-container > div.fc-dialog.fc-choice-dialog > div.fc-footer-buttons-container > div.fc-footer-buttons > button.fc-button.fc-cta-consent.fc-primary-button > p")).Click();
            page = new SveikatosSimptomaiPage(driver);
        }

        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
            page.CloseBrowser();
        }

        [Test]
        public static void TestSveikatosSimptomai ()
        {
            page.ClickButtonMoterys();
            page.ClickNusiskundimuGrupe();
            page.ClickAkiesSkausmas();
            page.ClickAkiuNiezejimas();
            page.ClickAkiuParaudimas();
            page.ClickAkiuPatinimas();
            page.ClickAkinaRyskiSviesa();
            page.ClickButton();
            page.VerifyResultLigos();

        }

    }
}