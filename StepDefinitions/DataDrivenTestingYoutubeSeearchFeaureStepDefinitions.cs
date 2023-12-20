using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class DataDrivenTestingYoutubeSeearchFeaureStepDefinitions
    {
        private IWebDriver driver;


        public DataDrivenTestingYoutubeSeearchFeaureStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }


        [Then(@"Search for '([^']*)'")]
        public void ThenSearchFor(string searchKey)
        {
            driver.FindElement(By.XPath("//*[@name='search_query']")).SendKeys(searchKey);
            driver.FindElement(By.XPath("//*[@name='search_query']")).SendKeys(Keys.Enter);
            Thread.Sleep(5000);
        }
    }
}
