using OpenQA.Selenium;

namespace WeddingPageTests.Pages
{
    public class HomePage : DriverHelper
    {
        IWebElement faqLink => Driver.FindElement(By.LinkText("/wedding/emilyjake2022/faq"));

        IWebElement rsvpLink => Driver.FindElement(By.LinkText("/wedding/emilyjake2022/rsvp"));

        public HomePage(IWebDriver driver)
        {
            Driver = driver;
        }

        public string GetPageTitle()
        {
            return Driver.FindElement(By.XPath("//h1[@id='public-page-title']/a")).Text;
        }

        public string GetName(int Num)
        {
            string firstInitial = Driver.FindElement(By.XPath($"//h1[@class='name-{Num}']//span[@class='[first-initial']")).Text;
            string firstRestOfName = Driver.FindElement(By.XPath($"//h1[@class='name-{Num}']//span[@class='full-first- name']")).Text;

            string lastInitial = Driver.FindElement(By.XPath($"//h1[@class='name-{Num}']//span[@class='last-initial']")).Text;
            string lastRestOfName = Driver.FindElement(By.XPath($"//h1[@class='name-{Num}']//span[@class='full-last-name']")).Text;

            String first = firstInitial + firstRestOfName;
            String last = lastInitial + lastRestOfName;

            return first + " " + last;
        }

        public void ClickFAQLink()
        {
            faqLink.Click(); 
        }

        public void ClickRSVPLink()
        {
            rsvpLink.Click();
        }
    }
}
