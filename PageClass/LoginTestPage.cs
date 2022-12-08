using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowTestProject.PageClass
{
    public class LoginTestPage
    {
        public IWebDriver driver;

        public LoginTestPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement Username => driver.FindElement(By.CssSelector("input[id='username']"));
        public IWebElement Password => driver.FindElement(By.CssSelector("input[id='password']"));
        public IWebElement SubmitButton => driver.FindElement(By.CssSelector("button[id='submit']"));
        public IWebElement ErrorMessage => driver.FindElement(By.CssSelector("div[id='error']"));
        public IWebElement SuccessMessage => driver.FindElement(By.CssSelector("p[class='has-text-align-center']"));
        public void PassingValues(string username,string password)
        {
            Username.SendKeys(username);
            Password.SendKeys(password);    
        }

        public void ClickSubmitButton()
        {
            SubmitButton.Click();
        }
        public void GetSuccessMessage()
        {
            string successmsg = SuccessMessage.Text;
            Console.WriteLine(successmsg);
        }
        public void CheckErrorMessage()
        {
            string errormsg = ErrorMessage.Text;
            Console.WriteLine(errormsg);
        }
    }
}
