using Docker.DotNet.Models;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace BaigiamasisDarbasInesa.Page
{
    public class ManoDaktarasPage : BasePage
    {
        private const string manoDaktarasUrl = "https://www.manodaktaras.lt/skaiciuokles/kmi";
        public IWebElement closeSutikima => Driver.FindElement(By.CssSelector("body > div.fc-consent-root > div.fc-dialog-container > div.fc-dialog.fc-choice-dialog > div.fc-footer-buttons-container > div.fc-footer-buttons > button.fc-button.fc-cta-consent.fc-primary-button > p"));
        private IWebElement inputFieldUgis => Driver.FindElement(By.Id("kmi-height"));
        private IWebElement inputFieldSvoris => Driver.FindElement(By.Id("kmi-weight"));
        private IWebElement clickKmiButton => Driver.FindElement(By.CssSelector("#kmi-test-form > div > div > button"));
        private IWebElement resultKmi => Driver.FindElement(By.CssSelector("body > div.body > div > div:nth-child(2) > div > div.col-lg-8 > div.section.section-test > div:nth-child(1) > div.result-block.result-block-kmi.success > p"));
        public ManoDaktarasPage(IWebDriver webDriver) : base (webDriver)
        {
            
        }
        public void NavigateToPage()
        {
            if (Driver.Url != manoDaktarasUrl)
            {
                Driver.Url = manoDaktarasUrl;
            }
           
        }

       
        public void closeSutikimaClick()
        {
           WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
           wait.Until(tempDriver => tempDriver.FindElement(By.CssSelector("body > div.fc-consent-root > div.fc-dialog-container > div.fc-dialog.fc-choice-dialog > div.fc-footer-buttons-container > div.fc-footer-buttons > button.fc-button.fc-cta-consent.fc-primary-button > p")).Displayed);
            closeSutikima.Click();
        }


        public void InputToFieldUgis(string asmensUgis)
        {
            inputFieldUgis.Clear();
            inputFieldUgis.SendKeys(asmensUgis);
        }

        public void InputToFieldSvoris(string asmensSvoris)
        {
            inputFieldSvoris.Clear();
            inputFieldSvoris.SendKeys(asmensSvoris);
        }

        public void ClickKmiButton()
        {
            clickKmiButton.Click(); 
        }

        public void VerifyResultKmi(string asmensKmi)
        {
            Assert.AreEqual(asmensKmi, resultKmi.Text, "KMI is wrong number");
        }
        

    }
}
