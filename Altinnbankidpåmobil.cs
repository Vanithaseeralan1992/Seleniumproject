using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seleniumproject
{
    class Altinnbankidpåmobil
    {
        [Test]
        public void bankidpåmobil()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://www.altinn.no/");

            //driver.Navigate().GoToUrl("https://www.altinn.no/ui/authentication");
            // driver.FindElement(By.("//button[@class='a - btn a - btn - border']")).Click(); ----not working code
            // driver.FindElement(By.ClassName("a-hvr-underline")).Click();      ----working code
            //driver.FindElement(By.ClassName("a-btn a-btn-border")).Submit();   -------not working code
            // driver.FindElement(By.XPath("//button[[@type,'button'] and [text()='Logg inn']")).Click();
            //driver.FindElement(By.TagName("button")).Click();
            /*driver.FindElement(By.Id("SSN_Input")).SendKeys("05069224816");
            driver.FindElement(By.Id("AltinnPinOneRequest_Pin")).SendKeys("12345");
            driver.FindElement(By.Id("submitFirstPinBtn")).Click();*/
            driver.FindElement(By.XPath("//button[@type='button' and @class='a-btn a-btn-border']")).Click();
            driver.FindElement(By.Id("BankIDMobil")).Click();
            driver.FindElement(By.Id("idporten.input.CONTACTINFO_MOBILE")).SendKeys("0987654321");
            //driver.FindElement(By.XPath("//input[@id='idporten.input.CONTACTINFO_MOBILE' and @placeholder='(8 digits)']")).SendKeys("97380179");  
            driver.FindElement(By.Id("idporten.input.BIRTHDATE")).SendKeys("090909");
            driver.FindElement(By.Id("nextbtn")).Click();
        }
    }
}