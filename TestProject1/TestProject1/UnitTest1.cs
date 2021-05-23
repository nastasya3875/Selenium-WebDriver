using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TestProject1.pages;

namespace TestProject1
{
     class Tests : AbstractPage
    {      
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
            HomePage homePage = logout.LoginVvod();
            HomePage homePage1 = logout.Check1();
        }

        [Test]
        public void Test2()
        {
            Logout logout = new Logout(driver);
            HomePage homePage = logout.LoginVvod();
            Products products = homePage.goProducts();
            Create create = products.goCreate();
            Products products1 = create.goProducts();
            Products products2 = products.Check2(); 
        }


        [Test]
        public void Test3()
        {
            Logout logout = new Logout(driver);
            HomePage homePage = logout.LoginVvod();
            Products products = homePage.goProducts();  
            Create create = products.goEditProduct();
            Products products1 = create.Check3();
        }


        [Test]
        public void Test4()
        {
            Logout logout = new Logout(driver);
            HomePage homePage = logout.LoginVvod();
            Products products = homePage.goProducts();
            Products products1 = products.goDelete();
            driver.SwitchTo().Alert().Accept();
        }

         [Test]
       public void Test5()
       {
            Logout logout = new Logout(driver);
            HomePage homePage = logout.LoginVvod();
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