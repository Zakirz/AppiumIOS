using AppiumIOSFramework.Application;
using AppiumIOSFramework.Pages;
using NUnit.Framework;

namespace AppiumIOSFramework.Tests.LoginTest
{
    [TestFixture]
    public class LoginTest: App
    {
            LoginPage loginPage = new LoginPage();

        [Test]
        public void TestStartAppAndLogin()
        {
            loginPage.LoginToApp("txmdkam", "Tika@234");
        }
    }
}
