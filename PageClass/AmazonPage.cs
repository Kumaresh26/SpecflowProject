using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowTestProject.PageClass
{
    public class AmazonPage
    {
        public IWebDriver driver;
        public AmazonPage(IWebDriver driver) 
        {
            this.driver = driver;
        }
        public IWebElement searchBar => driver.FindElement(By.Id("twotabsearchtextbox"));
        public IWebElement searchButton => driver.FindElement(By.Id("nav-search-submit-button"));

        public void PassingValues(string value)
        {
            searchBar.SendKeys(value);
        }

        public void ClickSearchButton()
        {
            searchButton.Click();
        }

        public bool VerifyTitle(string value)
        {
            try
            {
                string Title = driver.Title;
                Assert.That(Title, Does.Contain(value).IgnoreCase);
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
            
        }
    }
}
