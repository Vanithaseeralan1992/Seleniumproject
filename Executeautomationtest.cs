using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace Seleniumproject
{
    class Executeautomationtest
    {
        [Test]
        //static void Main(string[] args)
        public void Test()
        {
            IWebDriver driver = new ChromeDriver();

            //success code for execute automation test

            driver.Navigate().GoToUrl("http://eaapp.somee.com/");
            driver.FindElement(By.Id("loginLink")).Click();
            driver.FindElement(By.Id("UserName")).SendKeys("admin");
            driver.FindElement(By.Name("Password")).SendKeys("password");
            driver.FindElement(By.XPath("//input[@value='Log in']")).Submit();
            driver.Close();
            driver.Quit();

        }
        
    }
}
