using OpenQA.Selenium;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class DataDrivenTestingYoutubeSeearchWithParameterStepDefinitions
    {
        private IWebDriver driver;

        public DataDrivenTestingYoutubeSeearchWithParameterStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Then(@"Search with (.*)")]
        public void ThenSearchWithTesterTalkByPrashant(String searchKey)
        {
            Console.WriteLine("pj", searchKey);
            driver.FindElement(By.XPath("//*[@name='search_query']")).SendKeys(searchKey);
            driver.FindElement(By.XPath("//*[@name='search_query']")).SendKeys(Keys.Enter);
            Thread.Sleep(5000);
        }
    }
}
