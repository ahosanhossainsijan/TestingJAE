using OpenQA.Selenium;
using TestingJAE.Utility;

namespace TestingJAE.Pages
{
    public class MainPage : BasePage
    {
        public MainPage() : base(By.XPath("//div[contains(@class,'home__main')]"), "Main Page") { }

        private static IWebDriver driver => BrowserUtils.GetDriver();
        private IWebElement ButtonForNotAgree => driver.FindElement(By.XPath("//span[@class='didomi-continue-without-agreeing']"));
        private IWebElement LinkForNewsLetters => driver.FindElement(By.XPath("//a[contains(@href,'newsletters') and @data-event = 'header-events']"));

        public void ClickNotAgreeButton()
        {
            ButtonForNotAgree.Click();
        }

        public void GoToNewsletttersPage()
        {
            LinkForNewsLetters.Click();
        }
    }
}
