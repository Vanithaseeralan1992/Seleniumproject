using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace Seleniumproject
{
    class Testsearch_demo
    {

        [Test]
        public void SearchTest()
        {
            //Launch Browser
            IWebDriver driver = new ChromeDriver();
            // Naviate to URL https://www.codeproject.com
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMinutes(1);
            driver.Navigate().GoToUrl("https://www.codeproject.com");


            //Click on search our Articles
            driver.FindElement(By.XPath("//*[@id='ctl00_ContentPane']/div[1]/div/table[1]/tbody/tr/td[3]/a/img")).Click();
            //*[@id="ctl00_ContentPane"]/div[1]/div/table[1]/tbody/tr/td[3]/a/img
            //Enter Testing 
            driver.FindElement(By.Id("ctl00_MC_Query")).SendKeys("Testing");

            //Click on Search Button
            driver.FindElement(By.Id("ctl00_MC_Go")).Click();

            driver.Quit();
        }
    }
}
