using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestingJAE.Utility
{
    public class BrowserUtils
    {
        private BrowserUtils() { }

        private static IWebDriver driver;

        public static void OpenBrowserAndGoToUrl(string url)
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
        }

        public static IWebDriver GetDriver()
        {
            return driver;
        }

        public static void CloseBrowser()
        {
            if (driver != null)
            {
                driver.Quit();
            }
        }
    }
}
