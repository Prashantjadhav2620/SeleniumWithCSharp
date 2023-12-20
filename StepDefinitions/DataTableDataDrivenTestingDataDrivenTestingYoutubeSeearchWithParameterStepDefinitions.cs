using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class DataTableDataDrivenTestingDataDrivenTestingYoutubeSeearchWithParameterStepDefinitions
    {
        private IWebDriver driver;

        public DataTableDataDrivenTestingDataDrivenTestingYoutubeSeearchWithParameterStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Then(@"Enter search keyword in the Youtube")]
        public void ThenEnterSearchKeywordInTheYoutube(Table table)
        {
           var searchCriteria= table.CreateSet<SearchKetDataTable>();

            foreach(var ketDataTable in searchCriteria)
            {
                driver.FindElement(By.XPath("//*[@name='search_query']")).Clear(); 
                driver.FindElement(By.XPath("//*[@name='search_query']")).SendKeys(ketDataTable.searchkey);
                driver.FindElement(By.XPath("//*[@name='search_query']")).SendKeys(Keys.Enter);
                Thread.Sleep(5000);
            }

        }
    }

    public class SearchKetDataTable
    {
       public String searchkey { get; set;  }
    }
}
