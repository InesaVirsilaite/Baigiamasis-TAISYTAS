

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace BaigiamasisDarbasInesa.Page
{
    public class PaslaugosPage: BasePage
    {
        private IWebElement buttonPaslaugos => Driver.FindElement(By.XPath("/html/body/div[3]/div[1]/div/div/div[1]/form/div[1]/div/button[2]"));
        private IWebElement paslaugaInputField => Driver.FindElement(By.CssSelector("body > div.body > div.section.section-hero-form > div > div > div.col-12.col-lg-8.col-xl-7 > form > input.form-control.size-lg.query-analysis"));
        private IWebElement buttonVisiMiestai => Driver.FindElement(By.CssSelector("body > div.body > div.section.section-hero-form > div > div > div.col-12.col-lg-8.col-xl-7 > form > div:nth-child(5) > div.col-md-4 > span > span.selection > span"));
        private IWebElement inputMiestas => Driver.FindElement(By.CssSelector("body > span > span > span.select2-search.select2-search--dropdown > input"));
        private IWebElement buttonSearch => Driver.FindElement(By.CssSelector("body > div.body > div.section.section-hero-form > div > div > div.col-12.col-lg-8.col-xl-7 > form > div:nth-child(5) > div.col-md-2 > button > svg"));
        private IWebElement gerovesKlinika => Driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div[2]/div/div[3]/div/section/article/div/div[1]/div[1]/div[2]/div/a"));
     
        public PaslaugosPage(IWebDriver webDriver) : base (webDriver)
        {

        }
        public void ClickButtonPaslaugos()
        {
            buttonPaslaugos.Click();

        }
        public void FillpaslaugaInputField()
        {
            paslaugaInputField.Click();
            paslaugaInputField.SendKeys("Širdies - kraujagyslių ligų tyrimų programa. Vidutinė");

        }
        public void ClickbuttonVisiMiestai()
        {
            buttonVisiMiestai.Click();

        }
        public void ClickselectVilnius()
        {
            inputMiestas.SendKeys("Vilnius");
            inputMiestas.SendKeys(Keys.Enter);

        }
        public void ClickbuttonSearch()
        {
            buttonSearch.Click();

        }

        public void ReceivedGerovesKlinika()
        {
            Assert.AreEqual("GEROVĖS KLINIKA", gerovesKlinika.Text, "Klinika not found");
        }
  

    }
}
