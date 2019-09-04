using FluentAssertions;
using qa_services.selenium_dotnet_core_example.Models;
using Xunit;

namespace qa_services.selenium_dotnet_core_example.Tests
{
    public class ContactFormTests : BaseTest
    {
        [Fact]
        public void TestSubmitCorrectForm()
        {
            var contact = new Contact
            {
                Name = "New Client",
                Email = "correct@qa-services.dev",
                Message = "Message with proper length"
            };

            HomePage
                .GoToContact()
                .FillForm(contact)
                .SubmitForm()
                .GetSubmitButtonText()
                .Should().Be("MESSAGE SENT");
        }
    }
}
