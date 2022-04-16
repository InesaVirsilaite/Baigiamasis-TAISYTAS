

using OpenQA.Selenium;
using NUnit.Framework;
using System.Threading;

namespace BaigiamasisDarbasInesa.Page
{
    public class PrisijungimoLaukasPage : BasePage 

    {
        
        private IWebElement inputFieldVardas => Driver.FindElement(By.Id("registration_name"));
        private IWebElement inputFieldPavarde => Driver.FindElement(By.Id("registration_lastname"));
        private IWebElement buttonSukurtiPaskyra => Driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/div/form/button"));
        private string receivedMessage => Driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/div/form/div[4]/span")).GetAttribute("textContent");

        public PrisijungimoLaukasPage(IWebDriver webDriver) : base(webDriver)
        {

        }

        public void ClickOnVardas (string asmensVardas)
        {
            inputFieldVardas.Clear();
            inputFieldVardas.SendKeys(asmensVardas);
        }

        public void ClickOnPavarde (string asmensPavarde)
        {
            inputFieldPavarde.Clear();
            inputFieldPavarde.SendKeys(asmensPavarde);
        }

        public void ClickOnbuttonSukurtiPaskyra()
        {
            buttonSukurtiPaskyra.Click();
            Thread.Sleep(2000);
        }
        public void VerifyReceivedMessage(string gautasPranesimas)
        {
            Assert.AreEqual(gautasPranesimas, receivedMessage, "Pranešimo tekstas kitoks negu tiketasi"); 
        }






    }
}
