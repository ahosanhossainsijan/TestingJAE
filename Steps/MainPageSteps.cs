using NLog;
using NUnit.Framework;
using TestingJAE.Pages;

namespace TestingJAE.Steps
{
    public class MainPageSteps
    {
        private static MainPage mainPage => new MainPage();
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        public static void CheckMainPageIsOpened()
        {
            logger.Info("Main Page Opened");
            Assert.IsTrue(mainPage.IsPageOpened(), "Main Page is not opened");
        }

        public static void ClickOnNotAgreeButton()
        {
            logger.Info("Click Not Agree Button");
            mainPage.ClickNotAgreeButton();
        }

        public static void FollowNewslettersLink()
        {
            mainPage.GoToNewsletttersPage();
        }
    }
}
