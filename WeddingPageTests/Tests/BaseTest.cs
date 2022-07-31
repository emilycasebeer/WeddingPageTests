using OpenQA.Selenium.Chrome;

namespace WeddingPageTests.Tests
{
    public class BaseTest : DriverHelper
    {

        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Setup");
            Driver = new ChromeDriver();
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