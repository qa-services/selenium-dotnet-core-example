using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace qa_services.selenium_dotnet_core_example.Extensions
{
    public static class WebElementExtensions
    {
        public static void SetText(this IWebElement webElement, string text)
        {
            webElement.Clear();
            webElement.SendKeys(text);
        }
    }
}
