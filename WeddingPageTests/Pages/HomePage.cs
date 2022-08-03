using OpenQA.Selenium;

namespace WeddingPageTests.Pages
{
    public class HomePage : TopNavbar
    {
        public HomePage(IWebDriver driver)
        {
            Driver = driver;
        }

        public string GetHeaderTitle()
        {
            return Driver.FindElement(By.XPath("//h1[@id='public-page-title']/a")).Text;
        }

        public string GetName(int Num)
        {
            string firstInitial = Driver.FindElement(By.XPath($"//h1[@class='name-{Num}']//span[@class='first-initial']")).Text;
            string firstRestOfName = Driver.FindElement(By.XPath($"//h1[@class='name-{Num}']//span[@class='full-first-name']")).Text;

            string lastInitial = Driver.FindElement(By.XPath($"//h1[@class='name-{Num}']//span[@class='last-initial']")).Text;
            string lastRestOfName = Driver.FindElement(By.XPath($"//h1[@class='name-{Num}']//span[@class='full-last-name']")).Text;

            String first = firstInitial + firstRestOfName;
            String last = lastInitial + lastRestOfName;

            return first + " " + last;
        }
    }
}
