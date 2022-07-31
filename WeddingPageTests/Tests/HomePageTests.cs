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
            string pageTitle = homePage.GetPageTitle();
            string name1 = homePage.GetName(1);
            string name2 = homePage.GetName(2);
            // Assertions
            Assert.That(pageTitle, Is.EqualTo("Emily & Jake"));
            Assert.That(name1, Is.EqualTo("Emily Hamberg"));
            Assert.That(name2, Is.EqualTo("Jake Casebeer"));
        }
    }
}