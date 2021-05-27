using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TestProject1.dto;
using TestProject1.pages;

namespace TestProject1
{
     class Tests : AbstractPage
    {
        private User user = new User("user", "user");
        private Product product = new Product("Chai", "Beverages", "Exotic Liquids", "50", "36", "1", "1", "1", "Discontinued");

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
            Logout logout = new Logout(driver); 
            HomePage homePage = logout.LoginVvod(user);
            HomePage homePage1 = logout.Check1();
        }

        [Test]
        public void Test2()
        {
            Logout logout = new Logout(driver);
            HomePage homePage = logout.LoginVvod(user);
            Products products = homePage.goProducts();
            Create create = products.goCreate();
            Create create1 = create.goProducts(product);
            Products products2 = products.Check2();
        }

        [Test]
        public void Test3()
        {
            Logout logout = new Logout(driver);
            HomePage homePage = logout.LoginVvod(user);
            Products products = homePage.goProducts();  
            Create create = products.goEditProduct();
            Products products1 = create.Check3();
        }

        [Test]
        public void Test4()
        {
            Logout logout = new Logout(driver);
            HomePage homePage = logout.LoginVvod(user);
            Products products = homePage.goProducts();
            Products products1 = products.goDelete();
            driver.SwitchTo().Alert().Accept();
        }

         [Test]
       public void Test5()
       {
            Logout logout = new Logout(driver);
            HomePage homePage = logout.LoginVvod(user);
            Logout logout1 = homePage.goLogin();
            HomePage homePage1 = logout.Check4();
        }  

        [TearDown]
        public void TearDown() 
        {
           driver.Quit();
        }
    }
}