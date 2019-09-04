using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace qa_services.selenium_dotnet_core_example.PageObjects
{
    public class BasePage
    {
        public IWebDriver WebDriver { get; set; }
        public WebDriverWait DefaultWait { get; }

        public BasePage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
            DefaultWait = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(5));
        }
    }
}
