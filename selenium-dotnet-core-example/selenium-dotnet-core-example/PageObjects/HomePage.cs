using OpenQA.Selenium;

namespace qa_services.selenium_dotnet_core_example.PageObjects
{
    public class HomePage : BasePage
    {
        private IWebElement Menu => WebDriver.FindElement(By.Id("site-nav"));
        private IWebElement Contact => Menu.FindElement(By.CssSelector("a[href$=contact]"));

        public HomePage(IWebDriver webDriver) : base(webDriver)
        {
            webDriver.Navigate().GoToUrl(Settings.BaseUrl);
        }

        public ContactPage GoToContact()
        {
            Contact.Click();
            return new ContactPage(WebDriver);
        }
    }
}
