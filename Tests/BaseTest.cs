using NUnit.Framework;
using TestingJAE.Utility;

namespace TestingJAE.Tests
{
    public class BaseTest
    {
        private string url = JsonUtils.GetConfigData("url");

        [OneTimeSetUp]
        public void Open()
        {
            BrowserUtils.OpenBrowserAndGoToUrl(url);
        }

        [OneTimeTearDown] 
        public void Close()
        {
            BrowserUtils.CloseBrowser();
        }
    }
}
