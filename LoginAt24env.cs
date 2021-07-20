using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Seleniumproject
{
    public class LoginAt24env
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            IWebDriver driver = new ChromeDriver();

            
            driver.Navigate().GoToUrl("https://at24.altinn.cloud/");
            driver.FindElement(By.XPath("//button[@type='button' and @class='a-btn a-btn-border']")).Click();
           
            driver.FindElement(By.Id("otherLoginLink")).Click();
            driver.FindElement(By.Id("SSN_Input")).SendKeys("01086332090");
            driver.FindElement(By.Id("AltinnPinOneRequest_Pin")).SendKeys("12345");
            driver.FindElement(By.Id("submitFirstPinBtn")).Click();
            //driver.FindElement(By.Id("AltinnPinTwoRequest_Pin")).SendKeys("12345");
            //driver.FindElement(By.Name("AltinnPinTwoRequest.Pin")).SendKeys("12345");
            //driver.FindElement(By.XPath("//input[@class='form-control altinn-input valid' and @id='AltinnPinTwoRequest_Pin']")).SendKeys("12345");
            //driver.FindElement(By.ClassName("form-control altinn-input")).SendKeys("12345");
            //driver.FindElement(By.XPath("//input[@class='form-control altinn-input' and @autocomplete='off']")).SendKeys("12345");
            //driver.FindElement(By.XPath("//input[contains(@id,”AltinnPinTwoRequest_Pin”)]")).SendKeys("12345");
            driver.FindElement(By.XPath("/html/body/div/div[5]/div/div[1]/form/div/div/div/input")).SendKeys("12345");
            driver.FindElement(By.Id("submitSecondPinBtn")).Click();

        }
    }
}