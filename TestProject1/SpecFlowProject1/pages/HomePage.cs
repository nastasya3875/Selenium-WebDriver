using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FindsByAttribute = SeleniumExtras.PageObjects.FindsByAttribute;
using How = SeleniumExtras.PageObjects.How;

namespace TestProject1.pages
{
    class HomePage : AbstractPage
    {
        public HomePage(IWebDriver driver) {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//ul[@class='nav navbar-nav']/li[2]")]
        public IWebElement allproducts;

        [FindsBy(How = How.XPath, Using = "//a[@href='/Account/Logout']")]
        public IWebElement logout;

        [FindsBy(How = How.XPath, Using = "//h2[text()='Home page']")]
        public IWebElement nazvanie;

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
