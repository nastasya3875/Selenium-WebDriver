using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestProject1.pages
{
    class Products : AbstractPage
    {
        public Products(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[@class='btn btn-default']")]
        IWebElement createnew;

        [FindsBy(How = How.XPath, Using = "//a[@href='/Product/Remove?ProductId=78']")]
        IWebElement remove;

        [FindsBy(How = How.XPath, Using = "(//a[@href='/Product/Edit?ProductId=78'][1])")]
        IWebElement product;

        public Create goCreate()
        {
            createnew.Click();
           return new Create(driver);
        }

        public Create goEditProduct()
        {
            product.Click();
            return new Create(driver);
        }

        public Products goDelete()
        {
            remove.Click();
            return new Products(driver);
        }
        public Products Check2()
        {
            Assert.AreEqual("Create new", createnew.Text);
            return new Products(driver);
        }
    }
}
