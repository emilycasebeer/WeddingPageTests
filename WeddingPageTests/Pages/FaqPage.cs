using OpenQA.Selenium;

namespace WeddingPageTests.Pages
{
    public class FaqPage : TopNavbar
    {
        public FaqPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public string GetPageTitle()
        {
            return Driver.FindElement(By.CssSelector("#faq-page h1")).Text;
        }

        public int GetQuestionCount()
        {
            return Driver.FindElements(By.CssSelector(".faq-section")).Count();
        }
    }
}
