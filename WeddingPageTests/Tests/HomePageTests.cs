using OpenQA.Selenium;

namespace WeddingPageTests.Tests
{
    public class HomePageTests : BaseTest
    {

        [Test]
        public void VerifyHomePageTitleAndNames()
        {
            // Verify Page Title and First and Last names of people getting married
            string pageTitle = GetPageTitle();
            string name1 = GetFullName(1);
            string name2 = GetFullName(2);
            Assert.That(pageTitle, Is.EqualTo("Emily & Jake"));
            Assert.That(name1, Is.EqualTo("Emily Hamberg"));
            Assert.That(name2, Is.EqualTo("Jake Casebeer"));
        }

        public string GetPageTitle()
        {
            return Driver.FindElement(By.XPath("//h1[@id='public-page-title']/a")).Text;
        }

        public string GetFirstName(int Num)
        {
            string initial = Driver.FindElement(By.XPath($"//h1[@class='name-{Num}']//span[@class='first-initial']")).Text;
            string restOfName = Driver.FindElement(By.XPath($"//h1[@class='name-{Num}']//span[@class='full-first-name']")).Text;
            return initial + restOfName;
        }

        public string GetLastName(int Num)
        {
            string initial = Driver.FindElement(By.XPath($"//h1[@class='name-{Num}']//span[@class='last-initial']")).Text;
            string restOfName = Driver.FindElement(By.XPath($"//h1[@class='name-{Num}']//span[@class='full-last-name']")).Text;
            return initial + restOfName;
        }

        public string GetFullName(int Num)
        {
            return GetFirstName(Num) + " " + GetLastName(Num);
        }
    }
}