using AppiumIOSFramework.Core;
using NUnit.Framework;

namespace AppiumIOSFramework.Tests.LoginTest
{
    [TestFixture]
    public class LoginTest: Base
    {
        [Test]
        public void TestStartAppAndLogin()
        {
            //LogoutIfNot();
            var usernameLabel = driver.FindElementByAccessibilityId("Username");
            var passwordLabel = driver.FindElementByAccessibilityId("Password");
            
            bool usernameStatus = usernameLabel.Displayed;
            bool passwordStatus = passwordLabel.Displayed;
            Assert.IsTrue(usernameStatus);
            Assert.IsTrue(passwordStatus);
            var userTextBox = driver.FindElementByXPath("//XCUIElementTypeApplication[@name='KAM QA TEST']/XCUIElementTypeWindow[1]/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeTable/XCUIElementTypeCell[1]/XCUIElementTypeTextField");
            var passwordTextBox = driver.FindElementByXPath("//XCUIElementTypeApplication[@name='KAM QA TEST']/XCUIElementTypeWindow[1]/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeTable/XCUIElementTypeCell[2]/XCUIElementTypeSecureTextField");
            var loginButton = driver.FindElementByXPath("//XCUIElementTypeButton[@name='Login']");
            userTextBox.SendKeys("txmdkam");
            passwordTextBox.SendKeys("Tika@234");
            loginButton.Click();
            var DCMLink = driver.FindElementByAccessibilityId("Image3912. This is a Link.");
            DCMLink.Click();
        }

        public void LogoutIfNot()
        {
            var LogoutButton = driver.FindElementByAccessibilityId("Imagec67.This is a Link. ");
            if (LogoutButton.Displayed)
            {
                LogoutButton.Click();
                driver.SwitchTo().Alert().Accept();
            }
        }
    }
}
