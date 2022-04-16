

using BaigiamasisDarbasInesa.Drivers;
using BaigiamasisDarbasInesa.Page;
using BaigiamasisDarbasInesa.Tools;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;


namespace BaigiamasisDarbasInesa.Test
{
    public class BaseTest
    {
        protected static ManoDaktarasPage kmiSkaiciuoklePage;
        private static IWebDriver driver;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            driver = CustomDrivers.GetChrome();
            kmiSkaiciuoklePage = new ManoDaktarasPage(driver);
        }
        [TearDown]
        public static void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                MyScreenshot.TakeScreenshot(driver);
            }
        }
        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
            driver.Quit();
        }

    }
}
