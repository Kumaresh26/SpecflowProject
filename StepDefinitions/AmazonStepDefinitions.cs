using NUnit.Framework;
using OpenQA.Selenium;
using SpecFlowTestProject.PageClass;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace SpecFlowTestProject.StepDefinitions
{
    [Binding]
    public class AmazonStepDefinitions
    {
        private AmazonPage _amazonPage;
        private CommonPage _commonPage;

        public AmazonStepDefinitions( AmazonPage amazonPage, CommonPage commonPage)
        {
            _amazonPage = amazonPage;
            _commonPage = commonPage;
        }

        [Given(@"I launch an amazon application url '([^']*)'")]
        public void GivenILaunchAnAmazonApplicationUrl(string url)
        {
            _commonPage.launchApplication(url);
        }

        [When(@"I pass iphone '([^']*)' in search box")]
        public void WhenIPassIphoneInSearchBox(string value)
        {
            Thread.Sleep(2000);
            _amazonPage.PassingValues(value);
        }

        [When(@"I click the search button")]
        public void WhenIClickTheSearchButton()
        {
            Thread.Sleep(2000);
            _amazonPage.ClickSearchButton();
        }

        [Then(@"The title should contain '([^']*)' keyword")]
        public void ThenTheTitleShouldContainKeyword(string value)
        {
            Thread.Sleep(2000);
            Assert.True(_amazonPage.VerifyTitle(value));
        }

    }
}
