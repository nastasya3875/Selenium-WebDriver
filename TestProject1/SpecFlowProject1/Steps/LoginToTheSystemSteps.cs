using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using TestProject1.pages;

namespace SpecFlowProject1.Steps
{
    [Binding]

    public class LoginToTheSystemSteps
    {
        private IWebDriver driver;

        [Given(@"I open ""(.*)"" url")]
        public void GivenIOpenUrl(string url)
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
        
        [Given(@"I enter login")]
        public void GivenIEnterLogin()
        {
           new Logout(driver).name.SendKeys("user");
        }
        
        [Given(@"I enter password")]
        public void GivenIEnterPassword()
        {
            new Logout(driver).password.SendKeys("user");
        }
        
        [When(@"I click on submit button")]
        public void WhenIClickOnSubmitButton()
        {
            new Logout(driver).submitBtn.Click();
        } 
        
        [Then(@"The browser redirects me to the Home page")]
        public void ThenTheBrowserRedirectsMeToTheHomePage()
        {
            Assert.AreEqual("Home page", new Logout(driver).homePageElement.Text);
        }

        
    }
}
