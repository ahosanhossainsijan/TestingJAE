using OpenQA.Selenium;

namespace TestingJAE.Pages
{
    public class NewslettersPage : BasePage
    {
        public NewslettersPage() : base(By.XPath("//h1[contains(text(),'Our newsletters')]"), "Newsletters Page") { }


    }
}
