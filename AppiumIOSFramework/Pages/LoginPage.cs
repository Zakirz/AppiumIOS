using AppiumIOSFramework.Application;
using NUnit.Framework;

namespace AppiumIOSFramework.Pages
{
    class LoginPage:App
    {
        public string usernamelabel = "accessid###Username";
        public string passwordlabel = "accessid###Password";
        public string userTextbox = "xpath###//XCUIElementTypeApplication[@name='KAM QA TEST']/XCUIElementTypeWindow[1]/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeTable/XCUIElementTypeCell[1]/XCUIElementTypeTextField";
        public string pwdTextbox = "xpath###//XCUIElementTypeApplication[@name='KAM QA TEST']/XCUIElementTypeWindow[1]/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeTable/XCUIElementTypeCell[2]/XCUIElementTypeSecureTextField";
        public string loginButton = "xpath###//XCUIElementTypeButton[@name='Login']";

        public void LoginToApp(string username, string password)
        {
            Assert.IsTrue(IsDisplayed(usernamelabel));
            Assert.IsTrue(IsDisplayed(passwordlabel));
            EnterText(userTextbox, "txmdkam");
            EnterText(pwdTextbox, "Tika@234");
            ClickOn(loginButton);
        }
    }
}
