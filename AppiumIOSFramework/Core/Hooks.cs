using System;
using OpenQA.Selenium.Appium.iOS;
using NUnit.Framework;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Service;

namespace AppiumIOSFramework
{
    public class IOSAppTest
    {
        public static IOSDriver<IOSElement> driver;
        AppiumOptions options = new AppiumOptions();
        string testAppPath = Path.Combine("/Users/INDIUM/Downloads/KAM.test.qa.ipa");


        [OneTimeSetUp]
        public void SetupTest()
        { 
            options.AddAdditionalCapability("platformName", "iOS");
            options.AddAdditionalCapability("waitForDeviceTimeout", 120000);
            options.AddAdditionalCapability("derivedDataPath", "/Users/INDIUM/Library/Developer/Xcode/DerivedData/WebDriverAgent-alwvnomvwrdtzoaxbbkniqrpcdpp");
            options.AddAdditionalCapability("iosInstallPause", 10000);
            options.AddAdditionalCapability("usePrebuiltWDA", true);
            options.AddAdditionalCapability("noReset", true);
            options.AddAdditionalCapability("deviceName", "ISILPAD16");
            options.AddAdditionalCapability("platformVersion", "14.0");
            options.AddAdditionalCapability("automationName", "XCUITest");
            options.AddAdditionalCapability("udid", "2c326aa14c8d596509a090f6163c6a5a8e9a9090");
            options.AddAdditionalCapability("xCodeOrgId", "7AAC4DGPCP");
            options.AddAdditionalCapability("xCodeSigningId", "iPhone Developer");
            options.AddAdditionalCapability(MobileCapabilityType.App, testAppPath);
            Uri url = new Uri("http://localhost:4723/wd/hub");
            driver = new IOSDriver<IOSElement>(url, options, TimeSpan.FromMinutes(4));
            driver.LaunchApp();
            driver.Orientation = ScreenOrientation.Landscape;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
            Console.WriteLine("Driver Got Connected Succesfully");
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            if (driver != null)
            {
                Console.WriteLine("Test Completed and Driver Closed");
                driver.CloseApp();
                driver.Quit();
            }
        }

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