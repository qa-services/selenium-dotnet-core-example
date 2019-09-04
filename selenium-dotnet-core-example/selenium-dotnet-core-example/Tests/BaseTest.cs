using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using qa_services.selenium_dotnet_core_example.PageObjects;

namespace qa_services.selenium_dotnet_core_example.Tests
{
    public class BaseTest
    {
        public HomePage HomePage => new HomePage(InitializeBrowser());

        private static IWebDriver InitializeBrowser()
        {
            var driver = new ChromeDriver(".");
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            return driver;
        }
    }
}
