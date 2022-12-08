using NUnit.Framework;
using OpenQA.Selenium;
using SpecFlowTestProject.PageClass;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowTestProject.StepDefinitions
{
    [Binding]
    public class FlipkartStepDefinitions
    {
        private CommonPage _commonPage;
        private FlipkartPage _flipkartPage;
        public FlipkartStepDefinitions(IWebDriver driver,FlipkartPage flipkartPage, CommonPage commonPage)
        {
            _flipkartPage = flipkartPage;
            _commonPage = commonPage;   
        }

        [Given(@"I launch an flipkart application url '([^']*)'")]
        public void GivenILaunchAnFlipkartApplicationUrl(string url)
        {
            _commonPage.launchApplication(url);
        }

        [When(@"I close the login popup")]
        public void WhenICloseTheLoginPopup()
        {
            _commonPage.Click(_flipkartPage.closeLoginButton);
        }

        [When(@"I pass redmi '([^']*)' in search box")]
        public void WhenIPassRedmiInSearchBox(string value)
        {
            Thread.Sleep(2000);
            _commonPage.Sendkeys(_flipkartPage.searchBar, value);
        }

        [When(@"I click  search button")]
        public void WhenIClickSearchButton()
        {
            Thread.Sleep(2000);
            _commonPage.Click(_flipkartPage.searchButton);
        }

        [Then(@"The title should be contain '([^']*)' keyword")]
        public void ThenTheTitleShouldBeContainKeyword(string value)
        {
            Thread.Sleep(2000);
            Assert.True(_flipkartPage.VerifyTitle(value));
        }
    }
}
