using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestProject1.dto;

namespace TestProject1.pages
{
    class Logout : AbstractPage
    {
        public Logout(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//input[@id='Name']")]
        private IWebElement name;

        [FindsBy(How = How.XPath, Using = "//input[@id='Password']")]
        private IWebElement password;

        [FindsBy(How = How.XPath, Using = "//input[@class='btn btn-default']")]
        private IWebElement submitBtn;

        [FindsBy(How = How.XPath, Using = "//h2[text()='Home page']")]
        private IWebElement homePageElement;

        [FindsBy(How = How.XPath, Using = "//label[@for='Password']")]
        private IWebElement passwordtext;


        public HomePage LoginVvod(User user) {
            name.SendKeys(user.nameUs);
            password.SendKeys(user.passwordUs);
            submitBtn.Click();
            return new HomePage(driver);
        }

        public HomePage Check1() {
            Assert.AreEqual("Home page", homePageElement.Text);
            return new HomePage(driver);
        }

        public HomePage Check4()
        {  
            Assert.AreEqual("Password", passwordtext.Text);
            return new HomePage(driver);
        }

    }
}
