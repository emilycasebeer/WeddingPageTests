using WeddingPageTests.Pages;

namespace WeddingPageTests.Tests
{
    public class HomePageTests : BaseTest
    {

        [Test]
        public void VerifyHomePageTitleAndNames()
        {
            // Verify Page Title and First and Last names of people getting married
            HomePage homePage = new HomePage(Driver);
            Assert.That(homePage.GetHeaderTitle(), Is.EqualTo("Emily & Jake"));
            Assert.That(homePage.GetName(1), Is.EqualTo("Emily Hamberg"));
            Assert.That(homePage.GetName(2), Is.EqualTo("Jake Casebeer"));
        }
    }
}