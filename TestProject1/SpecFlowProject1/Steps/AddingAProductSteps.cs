using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using TestProject1.pages;

namespace SpecFlowProject1.Steps
{
    [Binding]

    public class AddingAProductSteps
    {
        private IWebDriver driver;

        [Given(@"I Open ""(.*)"" url")]
        public void GivenIOpenUrl(string url)
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
        
        [Given(@"I Enter login and password")]
        public void GivenIEnterLoginAndPassword()
        {
            Logout logout = new Logout(driver);
            logout.name.SendKeys("user");
            logout.password.SendKeys("user");
        }
        
        [Given(@"I Click on submit button")]
        public void GivenIClickOnSubmitButton()
        {
            new Logout(driver).submitBtn.Click();
        }
        
        [Given(@"I Click on All Products")]
        public void GivenIClickOnAllProducts()
        {
            new HomePage(driver).allproducts.Click();
        }
        
        [Given(@"I Click on Create New")]
        public void GivenIClickOnCreateNew()
        {
            new Products(driver).createnew.Click();
        }
        
        [Given(@"I Enter values into fields")]
        public void GivenIEnterValuesIntoFields()
        {
            Create create = new Create(driver);
            create.productname.SendKeys("Chai");
            create.category.SendKeys("Beverages");
            create.supplier.SendKeys("Exotic Liquids");
            create.unitprice.SendKeys("50");
            create.quantity.SendKeys("36");
            create.unitsinstock.SendKeys("1");
            create.unitsonorder.SendKeys("1");
            create.reorderlevel.SendKeys("2");
            create.discontinued.Click();
        }
        
        [When(@"I click on submit Button")]
        public void WhenIClickOnSubmitButton()
        {
            new Create(driver).createnew.Click();
        }
        
        [Then(@"The Create/edit form has closed")]
        public void ThenTheCreateEditFormHasClosed()
        {
            Assert.AreEqual("Create new", new Products(driver).createnew.Text);
        }

        [AfterScenario]
        public void CloseDriver()
        {
            driver.Close();
            driver.Quit();
        }

    }
}
