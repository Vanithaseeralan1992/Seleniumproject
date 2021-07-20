using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Seleniumproject
{
    [Binding]
    public class Searchtesting_ExampleSteps
    {
        public IWebDriver driver;
        [Given(@"Launch browser in chrome")]
        public void GivenLaunchBrowserInChrome()
        {
            driver = new ChromeDriver();
            // Naviate to URL https://www.codeproject.com
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMinutes(1);
        }
        
        [Given(@"Navidage to com project")]
        public void GivenNavidageToComProject()
        {
            driver.Navigate().GoToUrl("https://www.codeproject.com");
        }
        
        [When(@"Click on Search our Articles")]
        public void WhenClickOnSearchOurArticles()
        {
            //Click on search our Articles
            driver.FindElement(By.XPath("//*[@id='ctl00_ContentPane']/div[1]/div/table[1]/tbody/tr/td[3]/a/img")).Click();
        }
        
        [When(@"Enter Testing feild")]
        public void WhenEnterTestingFeild()
        {
            //Enter Testing 
            driver.FindElement(By.Id("ctl00_MC_Query")).SendKeys("Testing");
        }
        
        [When(@"Click on Search Button on the page")]
        public void WhenClickOnSearchButtonOnThePage()
        {
            //Click on Search Button
            driver.FindElement(By.Id("ctl00_MC_Go")).Click();
        }
        
        [Then(@"Result should be visible and Browser should close after testing")]
        public void ThenResultShouldBeVisibleAndBrowserShouldCloseAfterTesting()
        {
            driver.Quit();

        }
    }
}
