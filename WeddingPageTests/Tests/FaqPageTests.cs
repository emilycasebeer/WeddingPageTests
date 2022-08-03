using WeddingPageTests.Pages;

namespace WeddingPageTests.Tests
{
    public class FaqPageTests : BaseTest
    {
        [Test]
        public void VerifyNumberOfQuestions()
        {
            // Verify number of questions on FAQ page
            HomePage homePage = new HomePage(Driver);
            FaqPage faqPage = homePage.ClickFAQLink();
            Assert.That(faqPage.GetPageTitle(), Is.EqualTo("FAQ"));
            Assert.That(faqPage.GetQuestionCount(), Is.EqualTo(7));
        }
    }
}
