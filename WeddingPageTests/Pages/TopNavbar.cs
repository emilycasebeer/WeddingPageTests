using OpenQA.Selenium;

namespace WeddingPageTests.Pages
{
    public class TopNavbar : DriverHelper
    {
        IWebElement faqLink => Driver.FindElement(By.LinkText("FAQ"));

        public FaqPage ClickFAQLink()
        {
            faqLink.Click();
            return new FaqPage(Driver);
        }
    }
}
