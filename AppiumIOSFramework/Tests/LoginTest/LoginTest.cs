using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppiumIOSFramework.Tests.LoginTest
{
    public class LoginTest
    {
        [Test]
        public void TestStartAppAndLogin()
        {
            var usernameLabel = driver.FindElementByAccessibilityId("Username");
            var passwordLabel = driver.FindElementByAccessibilityId("Password");
            bool usernameStatus = usernameLabel.Displayed;
            bool passwordStatus = passwordLabel.Displayed;
            var userTextBox = driver.FindElementByXPath("//XCUIElementTypeApplication[@name='KAM QA TEST']/XCUIElementTypeWindow[1]/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeTable/XCUIElementTypeCell[1]/XCUIElementTypeTextField");
            var passwordTextBox = driver.FindElementByXPath("//XCUIElementTypeApplication[@name='KAM QA TEST']/XCUIElementTypeWindow[1]/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeTable/XCUIElementTypeCell[2]/XCUIElementTypeSecureTextField");
            var loginButton = driver.FindElementByXPath("//XCUIElementTypeButton[@name='Login']");
            userTextBox.SendKeys("txmdkam");
            passwordTextBox.SendKeys("Tika@234");
            loginButton.Click();
        }
    }
}
