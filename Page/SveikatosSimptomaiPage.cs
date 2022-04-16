
using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;

namespace BaigiamasisDarbasInesa.Page
{
    public class SveikatosSimptomaiPage : BasePage
    {
        IWebElement buttonMoterys => Driver.FindElement(By.CssSelector("#health-test-form > div > div:nth-child(2) > div > label:nth-child(2) > span"));
        IWebElement nenurodytiButton => Driver.FindElement(By.CssSelector("#health-test-form > div > div:nth-child(3) > span > span.selection > span"));
        IWebElement nusiskundimuGrupeField=> Driver.FindElement(By.CssSelector("body > span > span > span.select2-search.select2-search--dropdown > input"));
        IWebElement akiesSkausmas => Driver.FindElement(By.CssSelector("#health-test-form > div > div.complaints-list > div.row.complaints-checkboxes > div:nth-child(1) > label:nth-child(9) > svg"));
        IWebElement akiuPatinimas => Driver.FindElement(By.CssSelector("#health-test-form > div > div.complaints-list > div.row.complaints-checkboxes > div:nth-child(1) > label:nth-child(6) > svg"));
        IWebElement akinaRyskiSviesa => Driver.FindElement(By.CssSelector("#health-test-form > div > div.complaints-list > div.row.complaints-checkboxes > div:nth-child(1) > label:nth-child(3)"));
        IWebElement akiuNiezejimas => Driver.FindElement(By.CssSelector("#health-test-form > div > div.complaints-list > div.row.complaints-checkboxes > div:nth-child(1) > label:nth-child(4) > span"));
        IWebElement akiuParaudimas => Driver.FindElement(By.CssSelector("#health-test-form > div > div.complaints-list > div.row.complaints-checkboxes > div:nth-child(1) > label:nth-child(5) > span"));
        IWebElement akiuParaudimas2 => Driver.FindElement(By.CssSelector("#health-test-form > div > div.complaints-list > div.row.complaints-checkboxes > div:nth-child(1) > label:nth-child(5) > svg"));
        IWebElement button => Driver.FindElement(By.CssSelector("#health-test-form > div > div.complaints-list > button"));
        IWebElement resultLigos => Driver.FindElement(By.CssSelector("body > div.body > div > div:nth-child(2) > div > div.col-lg-8 > div > div:nth-child(1) > div.result-diseases > div:nth-child(2) > p > a"));


        public SveikatosSimptomaiPage(IWebDriver webDriver) : base(webDriver)
        {

        }
        public void ClickButtonMoterys()
        {
            buttonMoterys.Click();
        }
        public void ClickNusiskundimuGrupe ()
        {

            nenurodytiButton.Click();
            nusiskundimuGrupeField.SendKeys("Akies patologija");
            nusiskundimuGrupeField.SendKeys(Keys.Enter);
            Thread.Sleep(2000);

        }
        public void ClickAkiesSkausmas()
        {
            akiesSkausmas.Click();
        }
        public void ClickAkiuPatinimas()
        {
            akiuPatinimas.Click();
        }
        public void ClickAkinaRyskiSviesa()
        {
            akinaRyskiSviesa.Click();
        }

        public void ClickAkiuNiezejimas()
        {
            akiuNiezejimas.Click();
        }
        public void ClickAkiuParaudimas()
        {
            akiuParaudimas.Click();
        }

        public void ClickButton()
        {
            button.Click(); 
        }
        public void VerifyResultLigos()
        {
            Assert.AreEqual("Dakriocistitas", resultLigos.Text, "Text is wrong");
        }
    }
}
