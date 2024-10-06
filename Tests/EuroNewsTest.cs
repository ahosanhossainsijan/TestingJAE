using NUnit.Allure.Core;
using NUnit.Framework;
using TestingJAE.Steps;

namespace TestingJAE.Tests
{
    [TestFixture]
    [AllureNUnit]
    public class EuroNewsTest : BaseTest
    {
        [Test]
        public void EuroNewsPagesTest()
        {
            MainPageSteps.ClickOnNotAgreeButton();
            MainPageSteps.CheckMainPageIsOpened();
            MainPageSteps.FollowNewslettersLink();
            NewslettersPageSteps.CheckNewslettersPageOpned();
        }
    }
}