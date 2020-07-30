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

        [Test]
        public void AppLogin()
        {
            loginPage.LoginToApp(GLOBAL_USERNAME, GLOBAL_PASSWORD);
            Assert.IsTrue(homePage.HomePageDisplayed());
        }
    }
}
