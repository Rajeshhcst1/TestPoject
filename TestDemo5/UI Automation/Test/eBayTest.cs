using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using TestDemo5.UI_Automation.BaseClass;
using TestDemo5.UI_Automation.POM;

namespace TestDemo5.UI_Automation.Test
{
    [TestFixture]
    public class AddToCartTest: BaseClasses
    {
        private IConfiguration configuration;

        [SetUp]
        public void SetUp()
        {
            // Load configuration
            var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json");
            configuration = builder.Build();


            // Initialize driver
            string browser = configuration["Browser"];
            InitializeDriver(browser);
        }

        [Test]
        public void UIAutomation_Scenario1()
        {
            string baseUrl = configuration["BaseUrl"];

            // Navigate to eBay
            driver.Navigate().GoToUrl(baseUrl);

            // Create Page Objects
            HomePage homePage = new HomePage(driver);
            SearchResultsPage searchResultsPage = new SearchResultsPage(driver);
            ItemPage itemPage = new ItemPage(driver);

            // Perform actions
            homePage.SearchItem("book");
            searchResultsPage.ClickFirstItem();
            itemPage.AddToCart();

            // Verify cart count
            string cartCount = itemPage.GetCartCount();
            Assert.AreEqual("1", cartCount, "The cart count is not updated correctly.");
        }

        [TearDown]
        public void TearDown()
        {
            QuitDriver();
        }
    }
}
