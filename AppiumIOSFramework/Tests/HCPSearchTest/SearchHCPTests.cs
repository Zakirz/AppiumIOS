using AppiumIOSFramework.Application;
using AppiumIOSFramework.Pages;
using NUnit.Framework;

namespace AppiumIOSFramework.Tests.HCPSearchTest
{
    [TestFixture]
    public class SearchHCPTests: App
    {
            LoginPage loginPage = new LoginPage();
            HomeScreenPage homePage = new HomeScreenPage();
            CRSummaryPage crSummaryPage = new CRSummaryPage();
            HCPSearchPage hcpSearchPage = new HCPSearchPage();

        [Test]
        public void SearchHCPTest()
        {
            loginPage.LoginToApp(GLOBAL_USERNAME, GLOBAL_PASSWORD);
            homePage.OpenDCMLInk();
            Assert.IsTrue(crSummaryPage.SearchButtonDisplayed());
            crSummaryPage.ClickSearch();
        }
    }
}
