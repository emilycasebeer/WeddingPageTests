using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WeddingPageTests.Tests
{
    public class BaseTest
    {

        public IWebDriver Driver;

        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Setup");
            Driver = new ChromeDriver();
            //ChromeOptions options = new ChromeOptions();
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("https://www.zola.com/wedding/emilyjake2022");
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}