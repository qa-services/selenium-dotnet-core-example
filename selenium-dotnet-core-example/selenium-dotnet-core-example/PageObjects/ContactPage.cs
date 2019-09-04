using OpenQA.Selenium;
using qa_services.selenium_dotnet_core_example.Components;
using qa_services.selenium_dotnet_core_example.Models;

namespace qa_services.selenium_dotnet_core_example.PageObjects
{
    public class ContactPage : HomePage
    {
        private TextBox Name => new TextBox(WebDriver.FindElement(By.CssSelector("[data-qa=contact-name]")));
        private TextBox Email => new TextBox(WebDriver.FindElement(By.CssSelector("[data-qa=contact-email]")));
        private TextArea Message => new TextArea(WebDriver.FindElement(By.CssSelector("[data-qa=contact-message]")));
        private IWebElement SubmitButton => WebDriver.FindElement(By.Id("submit-btn"));

        public ContactPage(IWebDriver webDriver) : base(webDriver)
        {
        }

        public ContactPage FillForm(Contact contact)
        {
            Name.SetText(contact.Name);
            Email.SetText(contact.Email);
            Message.SetText(contact.Message);
            return this;
        }

        public ContactPage SubmitForm()
        {
            SubmitButton.Click();
            DefaultWait.Until(driver => driver.FindElement(By.Id("submit-btn")).Text != "SENDING...");
            return this;
        }

        public string GetSubmitButtonText()
        {
            return SubmitButton.Text;
        }
    }
}
