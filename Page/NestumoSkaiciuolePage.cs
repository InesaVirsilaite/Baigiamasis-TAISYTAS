

using NUnit.Framework;
using OpenQA.Selenium;

namespace BaigiamasisDarbasInesa.Page
{
    public class NestumoSkaiciuolePage : BasePage
    {
        private IWebElement fieldPaskutineMenesiniuDiena => Driver.FindElement(By.CssSelector("#pregnancy-calculator-date"));
        private IWebElement selectpaskutineMenesiniuDiena0401 => Driver.FindElement(By.CssSelector("#pregnancy-calculator-form > div > div > div > div:nth-child(1) > div > div > div.qs-squares > div:nth-child(12)"));
        private IWebElement buttonMenesiniuCikloTrukme => Driver.FindElement(By.CssSelector("#pregnancy-calculator-form > div > div > div > div:nth-child(2) > span > span.selection > span"));
        private IWebElement fieldMenesiniuCikloTrukme => Driver.FindElement(By.CssSelector("body > span > span > span.select2-search.select2-search--dropdown > input"));
        private IWebElement buttonSkaiciuoti=> Driver.FindElement(By.CssSelector("#pregnancy-calculator-form > div > div > button"));
        private IWebElement resultTextApytiksleNestumoData => Driver.FindElement(By.CssSelector("body > div.body > div > div:nth-child(2) > div > div.col-lg-8 > div.section.section-test > div:nth-child(1) > div.result-block.result-block-pregnancy > div > p.float-right"));
      
        public NestumoSkaiciuolePage(IWebDriver webDriver) : base(webDriver)
        {

        }
        public void InputToFieldPaskutineMenesiniuDiena()
        {
            fieldPaskutineMenesiniuDiena.Clear();
            fieldPaskutineMenesiniuDiena.Click();
            selectpaskutineMenesiniuDiena0401.Click();

        }
        public void ClickMenesiniuCikloTrukme()
        {
            buttonMenesiniuCikloTrukme.Click(); 
            fieldMenesiniuCikloTrukme.Click();
            fieldMenesiniuCikloTrukme.SendKeys("27");
            fieldMenesiniuCikloTrukme.SendKeys(Keys.Enter);

        }
        public void ClickButtonSkaiciuoti()
        {
            buttonSkaiciuoti.Click();   
        }
        public void VerifyResultGimdymoData()
        {
            Assert.AreEqual("Apytikslė gimdymo data:", resultTextApytiksleNestumoData.Text, "Negautas laukiamas tekstas 'apytiksle nestumo data'");
        }


    }
}
