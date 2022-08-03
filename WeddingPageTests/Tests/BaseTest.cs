using OpenQA.Selenium;

namespace WeddingPageTests.Tests
{
    public class BaseTest : DriverHelper
    {

        [SetUp]
        public virtual void Setup()
        {
            Driver = GetDriver();
            Driver.Navigate().GoToUrl("https://www.zola.com/wedding/emilyjake2022");
        }

        [TearDown]
        public virtual void TearDown()
        {
            Driver.Quit();
        }

        protected virtual IWebDriver GetDriver()
        {
            return WebDriverFactory.Create();
        }


    }
}