using OpenQA.Selenium;
using qa_services.selenium_dotnet_core_example.Extensions;

namespace qa_services.selenium_dotnet_core_example.Components
{
    public class TextBox
    {
        private readonly IWebElement _element;
        private IWebElement Input => _element.FindElement(By.CssSelector(".form-control"));
        private IWebElement Error => _element.FindElement(By.CssSelector(".help-block li"));

        public TextBox(IWebElement element)
        {
            _element = element;
        }

        public void SetText(string text)
        {
            Input.SetText(text);
        }

        public string GetText()
        {
            return Input.GetAttribute("value");
        }

        public bool HasError()
        {
            return _element.GetAttribute("class").Contains("has-error");
        }

        public string GetErrorText()
        {
            return Error.Text;
        }
    }
}
