using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace TestDemo5.UI_Automation.POM
{
    public class ItemPage
    {
        private IWebDriver driver;
        private By addToCartButton = By.XPath("//a[contains(@id,'atcBtn')]");
        private By cartCount = By.CssSelector("#gh-cart-n");

        public ItemPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void AddToCart()
        {
            string mainWindowHandle = driver.CurrentWindowHandle;

            // Wait for the new window or tab to open
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(100));
            wait.Until(driver => driver.WindowHandles.Count > 1);

            // Switch to the new window
            foreach (string handle in driver.WindowHandles)
            {
                if (handle != mainWindowHandle)
                {
                    driver.SwitchTo().Window(handle);
                    break;
                }
            }

            Thread.Sleep(1000);
            driver.FindElement(addToCartButton).Click();

        }

        public string GetCartCount()
        {
            return driver.FindElement(cartCount).Text;
        }
    }
}
