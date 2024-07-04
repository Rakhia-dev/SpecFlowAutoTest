using AutomationTaskC.PageObject;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace AutomationTaskC.StepDefinitions
{
    [Binding]
    public class SearchStepDefinitions
    {
        private IWebDriver driver;
        SearchPage searchPage;
        ResultPage resultPage;
        DetailsPage detailsPage;

        public SearchStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Given(@"I enter the url '([^']*)'")]
        public void GivenIEnterTheUrl(string url)
        {
            //driver = new ChromeDriver();
            driver.Url = url;
            Thread.Sleep(3000);

        }

        [When(@"I search for '([^']*)'")]
        public void WhenISearchFor(string searchtext)
        {
           searchPage = new SearchPage(driver);
          
           resultPage =  searchPage.searchText(searchtext);
        }

        [When(@"navigate to dynamic details page")]
        public void WhenNavigateToDynamicDetailsPage()
        {
            detailsPage = resultPage.clickOnlink();
        }

        [Then(@"dynamic page is displayed successfully")]
        public void ThenDynamicPageIsDisplayedSuccessfully()
        {
            detailsPage.verifyDynamicPageDisplayed();   
        }

    }
}
