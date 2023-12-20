using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1.Pages
{
    public class SearchPage
    {
        private IWebDriver driver;

        public SearchPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        By SearchTextBox = By.XPath("//*[@name='search_query']");

        public ResultPage searchText(String text) {
            
            driver.FindElement(SearchTextBox).SendKeys(text);
            driver.FindElement(SearchTextBox).SendKeys(Keys.Enter);
            //Thread.Sleep(5000);
            return new ResultPage(driver);
        }

    }
}
