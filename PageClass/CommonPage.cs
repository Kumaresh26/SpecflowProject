using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowTestProject.PageClass
{
    public class CommonPage
    {
        private IWebDriver _driver;
        public CommonPage(IWebDriver driver)
        {
            _driver = driver;
        }
        
        public void Click(IWebElement element)
        {
            element.Click();
        }

        public void Sendkeys(IWebElement element,string value)
        {
            element.SendKeys(value);
        }

        public void launchApplication(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }
    }
}
