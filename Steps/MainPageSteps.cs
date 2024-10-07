using NUnit.Framework;
using TestingJAE.Pages;

namespace TestingJAE.Steps
{
    public class MainPageSteps
    {
        private static MainPage mainPage => new MainPage();

        public static void CheckMainPageIsOpened()
        {
            Assert.IsTrue(mainPage.IsPageOpened(), "Main Page is not opened");
        }

        public static void ClickOnNotAgreeButton()
        {
            mainPage.ClickNotAgreeButton();
        }

        public static void FollowNewslettersLink()
        {
            mainPage.GoToNewsletttersPage();
        }
        //add
    }
}
