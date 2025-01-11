using OpenQA.Selenium;

namespace TestDemo5.UI_Automation.POM
{
    public class SearchResultsPage
    {
        private IWebDriver driver;
        private By firstItem = By.CssSelector("ul.srp-results li.s-item a.s-item__link");

        public SearchResultsPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void ClickFirstItem()
        {
            driver.FindElement(firstItem).Click();
        }
    }
}
