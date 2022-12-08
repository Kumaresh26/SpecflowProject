using NUnit.Framework;
using SpecFlowTestProject.PageClass;
using System;
using System.Security.AccessControl;
using TechTalk.SpecFlow;

namespace SpecFlowTestProject.StepDefinitions
{
    [Binding]
    public class LoginTestStepDefinitions
    {
        private LoginTestPage _loginTestPage;
        private CommonPage _commanPage;
        public LoginTestStepDefinitions(LoginTestPage loginTestPage,CommonPage commonPage) 
        { 
            _loginTestPage= loginTestPage;
            _commanPage= commonPage;
        }

        [Given(@"I launch an Login Test application url '([^']*)'")]
        public void GivenILaunchAnLoginTestApplicationUrl(string url)
        {
            _commanPage.launchApplication(url);
        }

        [When(@"I pass the username '([^']*)' and password '([^']*)'")]
        public void WhenIPassTheUsernameAndPassword(string username, string password)
        {
            Thread.Sleep(2000);
            _loginTestPage.PassingValues(username, password);
        }

        [When(@"I click the login button")]
        public void WhenIClickTheLoginButton()
        {
            Thread.Sleep(2000);
            _loginTestPage.ClickSubmitButton();
        }

        [Then(@"I get the message")]
        public void ThenIGetTheMessage()
        {
            try
            {
                _loginTestPage.GetSuccessMessage();
            }
            catch
            {
                _loginTestPage.CheckErrorMessage();
            }
        }
    }
}
