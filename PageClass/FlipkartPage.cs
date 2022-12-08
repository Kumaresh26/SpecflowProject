using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowTestProject.PageClass
{
    public class FlipkartPage
    {
        public IWebDriver driver;
        public FlipkartPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement closeLoginButton => driver.FindElement(By.CssSelector("button[class='_2KpZ6l _2doB4z']"));
        public IWebElement searchBar => driver.FindElement(By.CssSelector("input[name='q']"));
        public IWebElement searchButton => driver.FindElement(By.XPath("//form[contains(@class,'form-search')]//button"));


        public void CloseLogin()
        {
            closeLoginButton.Click();
        }

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
            catch 
            {
                return false;
            }

        }

    }
}
