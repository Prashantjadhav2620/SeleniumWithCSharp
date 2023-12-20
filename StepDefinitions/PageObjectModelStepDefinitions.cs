using NUnit.Framework;
using OpenQA.Selenium;
using SpecFlowProject1.Pages;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class PageObjectModelStepDefinitions
    {
        private IWebDriver driver;

        SearchPage searchPage;
        ResultPage resultPage;
        ChannelPage channelPage;

        public PageObjectModelStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Given(@"Enter the URL")]
        public void GivenEnterTheURL()
        {
            driver.Url = "https://www.youtube.com/";
            Thread.Sleep(5000);
        }

        [When(@"Search for tester talk in youtube")]
        public void WhenSearchForTesterTalkInYoutube()
        {
            searchPage = new SearchPage(driver);
            resultPage=searchPage.searchText("Tester Talk");
            Thread.Sleep(5000);
        }

        [When(@"Navigate to channel")]
        public void WhenNavigateToChannel()
        {
          //  resultPage = new ResultPage(driver);
            resultPage.clickOnChannel();
            Thread.Sleep(5000);
        }

        [Then(@"verify the tittle of page")]
        public void ThenVerifyTheTittleOfPage()
        {
            Assert.Equals("Testers Talk — Youtube", channelPage.getTittle()); 
        }
    }
}
