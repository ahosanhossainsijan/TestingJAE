using NUnit.Framework;
using TestingJAE.Pages;

namespace TestingJAE.Steps
{
    public class NewslettersPageSteps
    {
        private static NewslettersPage newslettersPage = new NewslettersPage();

        public static void CheckNewslettersPageOpned()
        {
            Assert.IsTrue(newslettersPage.IsPageOpened(), "Newsletters page is not opened");
        }
    }
}
