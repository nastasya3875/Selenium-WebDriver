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
    class Create : AbstractPage
    {
        public Create(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//input[@id='ProductName']")]
        IWebElement productname;

        [FindsBy(How = How.XPath, Using = "//select[@id='CategoryId']")]
        IWebElement category;

        [FindsBy(How = How.XPath, Using = "//select[@id='SupplierId']")]
        IWebElement supplier;

        [FindsBy(How = How.XPath, Using = "//input[@id='UnitPrice']")]
        IWebElement unitprice;

        [FindsBy(How = How.XPath, Using = "//input[@id='QuantityPerUnit']")]
        IWebElement quantity;

        [FindsBy(How = How.XPath, Using = "//input[@id='UnitsInStock']")]
        IWebElement unitsinstock;

        [FindsBy(How = How.XPath, Using = "//input[@id='UnitsOnOrder']")]
        IWebElement unitsonorder;

        [FindsBy(How = How.XPath, Using = "//input[@id='ReorderLevel']")]
        IWebElement reorderlevel;

        [FindsBy(How = How.XPath, Using = "//input[@id='Discontinued']")]
        IWebElement discontinued;

        [FindsBy(How = How.XPath, Using = "//input[@class='btn btn-default']")]
        IWebElement send;

        [FindsBy(How = How.XPath, Using = "//input[@id='ProductId']")]
        IWebElement productId;

        [FindsBy(How = How.XPath, Using = "//a[@class='btn btn-default']")]
        IWebElement createnew;


        public Create goProducts(Product product)
        {
            productname.SendKeys(product.Productname);
            category.SendKeys(product.Category);
            supplier.SendKeys(product.Supplier);
            unitprice.SendKeys(product.UnitPrice);
            quantity.SendKeys(product.QuantityPerUnit);
            unitsinstock.SendKeys(product.UnitsInStock);
            unitsonorder.SendKeys(product.UnitsOnOrder);
            reorderlevel.SendKeys(product.ReorderLevel);
            discontinued.Click();
            send.Click();
            return new Create(driver);
        }

        public Products Check3()
        {
            Assert.AreEqual("78", productId.GetAttribute("value"));
            Assert.AreEqual("Chai", productname.GetAttribute("value"));
            Assert.IsTrue(category.Text.Contains("Beverages"));
            Assert.IsTrue(supplier.Text.Contains("Exotic Liquids"));
            Assert.AreEqual("50,0000", unitprice.GetAttribute("value"));
            Assert.AreEqual("36", quantity.GetAttribute("value"));
            Assert.AreEqual("1", unitsinstock.GetAttribute("value"));
            Assert.AreEqual("1", unitsonorder.GetAttribute("value"));
            Assert.AreEqual("1", reorderlevel.GetAttribute("value"));
            Assert.AreEqual("true", discontinued.GetAttribute("value"));
            return new Products(driver);
        }
    }
}
