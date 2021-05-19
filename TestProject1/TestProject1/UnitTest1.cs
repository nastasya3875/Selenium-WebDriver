using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace TestProject1
{
    public class Tests
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:5000/Account/Login?ReturnUrl=%2F");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [Test]
        public void Test1()
        {
            IWebElement queryStr1 = driver.FindElement(By.XPath("//input[@id='Name']"));
            queryStr1.SendKeys("user");

            IWebElement queryStr2 = driver.FindElement(By.XPath("//input[@id='Password']"));
            queryStr2.SendKeys("user");

            IWebElement submitBtn = driver.FindElement(By.XPath("//input[@class='btn btn-default']"));
            submitBtn.Click();

            IWebElement nazvanie = driver.FindElement(By.XPath("//h2[text()='Home page']"));
            Assert.AreEqual("Home page", nazvanie.Text);

        }

        [Test]
        public void Test2()
        {
            IWebElement queryStr1 = driver.FindElement(By.XPath("//input[@id='Name']"));
            queryStr1.SendKeys("user");

            IWebElement queryStr2 = driver.FindElement(By.XPath("//input[@id='Password']"));
            queryStr2.SendKeys("user");

            IWebElement submitBtn = driver.FindElement(By.XPath("//input[@class='btn btn-default']"));
            submitBtn.Click();

            IWebElement nazvanie = driver.FindElement(By.XPath("//h2[text()='Home page']"));
            Assert.AreEqual("Home page", nazvanie.Text);

            //d //
            
            IWebElement allproducts = driver.FindElement(By.XPath("//ul[@class='nav navbar-nav']/li[2]"));
            allproducts.Click();

            IWebElement createnew = driver.FindElement(By.XPath("//a[@class='btn btn-default']"));
            createnew.Click();

            IWebElement productname = driver.FindElement(By.XPath("//input[@id='ProductName']"));
            productname.SendKeys("Chai");

            IWebElement category = driver.FindElement(By.XPath("//select[@id='CategoryId']"));
            category.SendKeys("Beverages");

            IWebElement supplier = driver.FindElement(By.XPath("//select[@id='SupplierId']"));
            supplier.SendKeys("Exotic Liquids");

            IWebElement unitprice = driver.FindElement(By.XPath("//input[@id='UnitPrice']"));
            unitprice.SendKeys("50");

            IWebElement quantity = driver.FindElement(By.XPath("//input[@id='QuantityPerUnit']"));
            quantity.SendKeys("36");

            IWebElement unitsinstock = driver.FindElement(By.XPath("//input[@id='UnitsInStock']"));
            unitsinstock.SendKeys("1");

            IWebElement unitsonorder = driver.FindElement(By.XPath("//input[@id='UnitsOnOrder']"));
            unitsonorder.SendKeys("1");

            IWebElement reorderlevel = driver.FindElement(By.XPath("//input[@id='ReorderLevel']"));
            reorderlevel.SendKeys("1");

            IWebElement discontinued = driver.FindElement(By.XPath("//input[@id='Discontinued']"));
            discontinued.Click();

            IWebElement send = driver.FindElement(By.XPath("//input[@class='btn btn-default']"));
            send.Click();

            IWebElement createnew2 = driver.FindElement(By.XPath("//a[@class='btn btn-default']"));
            Assert.AreEqual("Create new", createnew2.Text);
        }

        [Test]
        public void Test3()
        {
            IWebElement queryStr1 = driver.FindElement(By.XPath("//input[@id='Name']"));
            queryStr1.SendKeys("user");

            IWebElement queryStr2 = driver.FindElement(By.XPath("//input[@id='Password']"));
            queryStr2.SendKeys("user");

            IWebElement submitBtn = driver.FindElement(By.XPath("//input[@class='btn btn-default']"));
            submitBtn.Click();

            IWebElement allproducts = driver.FindElement(By.XPath("//ul[@class='nav navbar-nav']/li[2]"));
            allproducts.Click();

            IWebElement product = driver.FindElement(By.XPath("//a[@href='/Product/Edit?ProductId=89']"));
            product.Click();

            IWebElement productId = driver.FindElement(By.XPath("//input[@id='ProductId']"));       
            Assert.IsFalse(productId.Text.Contains("89"));

            IWebElement productname = driver.FindElement(By.XPath("//input[@id='ProductName']"));
            Assert.IsFalse(productname.Text.Contains("Chai"));

            IWebElement category = driver.FindElement(By.XPath("//select[@id='CategoryId']"));
            Assert.IsTrue(category.Text.Contains("Beverages"));

            IWebElement supplier = driver.FindElement(By.XPath("//select[@id='SupplierId']"));
            Assert.IsTrue(supplier.Text.Contains("Exotic Liquids"));
            
            IWebElement unitprice = driver.FindElement(By.XPath("//input[@id='UnitPrice']"));
            Assert.IsFalse(unitprice.Text.Contains("50,0000"));
         
            IWebElement quantity = driver.FindElement(By.XPath("//input[@id='QuantityPerUnit']"));
            Assert.IsFalse(quantity.Text.Contains("36"));

            IWebElement unitsinstock = driver.FindElement(By.XPath("//input[@id='UnitsInStock']"));
            Assert.IsFalse(unitsinstock.Text.Contains("1"));

            IWebElement unitsonorder = driver.FindElement(By.XPath("//input[@id='UnitsOnOrder']"));
            Assert.IsFalse(unitsonorder.Text.Contains("1"));
            
            IWebElement reorderlevel = driver.FindElement(By.XPath("//input[@id='ReorderLevel']"));
            Assert.IsFalse(reorderlevel.Text.Contains("1"));

            // не могу проверить флажок
           // IWebElement discontinued = driver.FindElement(By.XPath("//input[@id='Discontinued']"));
           // Assert. 
        }

        [Test]
        public void Test4()
        {
            IWebElement queryStr1 = driver.FindElement(By.XPath("//input[@id='Name']"));
            queryStr1.SendKeys("user");

            IWebElement queryStr2 = driver.FindElement(By.XPath("//input[@id='Password']"));
            queryStr2.SendKeys("user");

            IWebElement submitBtn = driver.FindElement(By.XPath("//input[@class='btn btn-default']"));
            submitBtn.Click();

            IWebElement allproducts = driver.FindElement(By.XPath("//ul[@class='nav navbar-nav']/li[2]"));
            allproducts.Click();

            IWebElement remove = driver.FindElement(By.XPath("//a[@href='/Product/Remove?ProductId=88']"));
            remove.Click(); 
        }

        [Test]
        public void Test5()
        {
            IWebElement queryStr1 = driver.FindElement(By.XPath("//input[@id='Name']"));
            queryStr1.SendKeys("user");

            IWebElement queryStr2 = driver.FindElement(By.XPath("//input[@id='Password']"));
            queryStr2.SendKeys("user");

            IWebElement submitBtn = driver.FindElement(By.XPath("//input[@class='btn btn-default']"));
            submitBtn.Click();

            //g//

            IWebElement logout = driver.FindElement(By.XPath("//a[@href='/Account/Logout']"));
            logout.Click();

            IWebElement name = driver.FindElement(By.XPath("//label[@for='Name']"));
            Assert.AreEqual("Name", name.Text);

            IWebElement password = driver.FindElement(By.XPath("//label[@for='Password']"));
            Assert.AreEqual("Password", password.Text);
        }

        [TearDown]
        public void TearDown() {
           driver.Quit();
       }
    }
}