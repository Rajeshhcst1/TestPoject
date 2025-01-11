//// NUnit 3 tests
//// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
//using System.Collections;
//using System.Collections.Generic;
//using NUnit.Framework;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Firefox;
//using System;
//using System.Threading;
//using OpenQA.Selenium.Support.UI;

//namespace TestDemo5
//{
//    [TestFixture]
//    public class TestClass
//    {
//        IWebDriver driver;
//        String test_url = "http://website.multiformis.com/";
//        [SetUp]
//        public void Setup()
//        {
//            driver = new FirefoxDriver();
//            driver.Manage().Window.Maximize();
//            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(500);
//            driver.Navigate().GoToUrl(test_url);
//        }

//        [TearDown]
//        public void CleanUp()
//        {
//            driver.Quit();
//        }
//        [Test]
//        public void TestMethod()
//        {
//            IWebElement alert = driver.FindElement(By.XPath("/html/body/div[2]/div/button"));
//            alert.Click();
//            Thread.Sleep(200);
//            driver.FindElement(By.XPath("/html/body/div[1]/header/nav/div[2]/ul/li[2]/a")).Click();
//            Thread.Sleep(200);
//            SelectElement s = new SelectElement(driver.FindElement(By.XPath("/html/body/div/div/div/main/article/div/div/div[1]/label/select")));
//            s.SelectByValue("25");
//            Thread.Sleep(200);
//            driver.FindElement(By.XPath("/html/body/div/div/div/main/article/div/div/table/thead/tr/th[8]")).Click();
//            Thread.Sleep(200);
//            driver.FindElement(By.XPath("/html/body/div/div/div/main/article/div/div/table/thead/tr/th[8]")).Click();

//            string age = driver.FindElement(By.XPath("/html/body/div/div/div/main/article/div/div/table/tbody/tr[1]/td[8]")).Text;


//            Assert.IsTrue(Convert.ToInt32(age) > 65);


//        }
//    }
//}
