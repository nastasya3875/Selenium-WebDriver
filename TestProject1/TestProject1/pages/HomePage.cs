using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestProject1.pages
{
    class HomePage : AbstractPage
    {
        public HomePage(IWebDriver driver) {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//ul[@class='nav navbar-nav']/li[2]")]
        IWebElement allproducts;

        [FindsBy(How = How.XPath, Using = "//a[@href='/Account/Logout']")]
        IWebElement logout;

        [FindsBy(How = How.XPath, Using = "//h2[text()='Home page']")]
        IWebElement nazvanie;

        public Products goProducts() {
            allproducts.Click();
            return new Products(driver);
        }

        public Logout goLogin()
        {
            logout.Click();
            return new Logout(driver);
        }
    }
}
