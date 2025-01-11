using OpenQA.Selenium;

namespace TestDemo5.UI_Automation.POM
{
    public class ItemPage
    {
        private IWebDriver driver;
        //private By addToCartButton = By.XPath("//a[contains(@id,'atcBtn')]");
        private By addToCartButton = By.Id("atcBtn_btn_1");
        private By cartCount = By.CssSelector("#gh-cart-n");

        public ItemPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void AddToCart()
        {
            driver.FindElement(addToCartButton).Click();
        }

        public string GetCartCount()
        {
            return driver.FindElement(cartCount).Text;
        }
    }
}
