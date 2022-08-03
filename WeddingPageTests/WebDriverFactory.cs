using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using WeddingPageTests.Variables;

namespace WeddingPageTests
{
    internal class WebDriverFactory : DriverHelper
    {
        static TestSettings config;
        static string configsettingpath = System.IO.Directory.GetParent(@"../../../").FullName
            + Path.DirectorySeparatorChar + "Config/config.json";

        public static IWebDriver Create()
        {
            IWebDriver driver = null;
            config = new TestSettings();
            ConfigurationBuilder builder = new ConfigurationBuilder();
            builder.AddJsonFile(configsettingpath);
            IConfigurationRoot configuration = builder.Build();
            configuration.Bind(config);

            string browser = config.BrowserType.ToLower();

            switch (browser)
            {
                case "firefox":
                    driver = new FirefoxDriver();
                    driver.Manage().Window.Maximize();
                    break;
                case "chrome":
                    var options = new ChromeOptions();
                    options.AddArgument("start-maximized");
                    driver = new ChromeDriver(options);
                    break;
                case "ie":
                    driver = new InternetExplorerDriver();
                    driver.Manage().Window.Maximize();
                    break;
                default:
                    throw new Exception($"{browser} not supported");
            }
            return driver;
        }
    }
}
