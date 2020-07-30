using AppiumIOSFramework.Application;
using AppiumIOSFramework.Pages;
using NUnit.Framework;

namespace AppiumIOSFramework.Tests.LoginTest
{
    [TestFixture]
    public class LoginTest: App
    {
            LoginPage loginPage = new LoginPage();
            HomeScreenPage homePage = new HomeScreenPage();
            CRSummaryPage crSummaryPage = new CRSummaryPage();
            HCPSearchPage hcpSearchPage = new HCPSearchPage();

        [Test]
        public void TestStartAppAndLogin()
        {
            loginPage.LoginToApp("txmdkam", "Tika@234");
            homePage.OpenDCMLInk();
            Assert.IsTrue(crSummaryPage.SearchButtonDisplayed());
            crSummaryPage.ClickSearch();            
        }
    }
}
