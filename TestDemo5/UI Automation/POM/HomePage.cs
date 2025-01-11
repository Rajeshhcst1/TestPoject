using OpenQA.Selenium;

namespace TestDemo5.UI_Automation.POM
{
    public class HomePage
    {
        private IWebDriver driver;
        private By searchBox = By.Id("gh-ac");
        private By searchButton = By.Id("gh-btn");

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void SearchItem(string item)
        {
            driver.FindElement(searchBox).SendKeys(item);
            driver.FindElement(searchButton).Click();
        }
    }
}
