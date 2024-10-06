using OpenQA.Selenium;
using TestingJAE.Utility;

namespace TestingJAE.Pages
{
    public class BasePage
    {
        private readonly By locator;
        private readonly string title;
        public BasePage(By locator, string title) 
        {
            this.locator = locator;
            this.title = title;
        }

        private IWebDriver driver = BrowserUtils.GetDriver();

        public bool IsPageOpened()
        {
            return driver.FindElements(locator).Count > 0;
        }
    }
}
