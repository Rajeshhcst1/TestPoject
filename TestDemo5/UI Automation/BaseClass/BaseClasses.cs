using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;

namespace TestDemo5.UI_Automation.BaseClass
{
        public class BaseClasses
        {
            protected IWebDriver driver;

            public void InitializeDriver(string browser)
            {
                switch (browser.ToLower())
                {
                    case "chrome":
                        driver = new ChromeDriver();
                        break;
                    case "firefox":
                        driver = new FirefoxDriver();
                        break;
                    case "edge":
                        driver = new EdgeDriver();
                        break;
                    default:
                        throw new ArgumentException("Unsupported browser type");
                }

                driver.Manage().Window.Maximize();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            }

            public void QuitDriver()
            {
                driver.Quit();
            }
        }
}
