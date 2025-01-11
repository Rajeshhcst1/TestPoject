//using NUnit.Framework;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Firefox;
//using OpenQA.Selenium.Support.UI;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace TestDemo5
//{
//    class Exercise
//    {
//        IWebDriver driver;
//        String test_url = "https://www.ebay.com/";

//        [SetUp]
//        public void Setup()
//        {
//            driver = new FirefoxDriver();
//            driver.Manage().Window.Maximize();
//            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(500);     
//        }

//        [TearDown]
//        public void CleanUp()
//        {
//            driver.Quit();
//        }
//        [Test]
//        public void UIAutomation-1()
//        {
//            // Step 1: Open browser and navigate to eBay
//            driver.Navigate().GoToUrl(test_url);
//            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(100));

//            // Step 2: Search for 'book'
//            IWebElement searchBox = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("gh-ac")));
//            searchBox.SendKeys("book");
//            searchBox.SendKeys(Keys.Enter);

//            // Step 3: Click on the first book in the list
//            IWebElement firstItem = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("ul.srp-results li.s-item a.s-item__link")));
//            firstItem.Click();

//            // Step 4: In the item listing page, click on 'Add to cart'
//            //   IWebElement addToCartButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//a[contains(@id,'atcBtn')]")));
//            //   addToCartButton.Click();

//            // Step 5: Verify the cart has been updated
//            IWebElement cartCount = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#gh-cart-n")));
//                if (int.Parse(cartCount.Text) > 0)
//                {
//                    Console.WriteLine("Test Passed: Item successfully added to the cart.");
//                }
//                else
//                {
//                    throw new Exception("Cart count did not update as expected.");
//                }
            
//        }
//    }
//}
