using System;
using OpenQA.Selenium.Appium.iOS;
using NUnit.Framework;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Service;

namespace AppiumIOSFramework.Core
{
    public class Base : Config
    {
        public static IOSDriver<IOSElement> driver;

        public AppiumOptions IOSCapability()
        {
            AppiumOptions options = new AppiumOptions();
            options.AddAdditionalCapability("platformName", "iOS");
            options.AddAdditionalCapability("waitForDeviceTimeout", 120000);
            options.AddAdditionalCapability("derivedDataPath", DERIVED_DATA_PATH);
            options.AddAdditionalCapability("iosInstallPause", 10000);
            options.AddAdditionalCapability("usePrebuiltWDA", true);
            options.AddAdditionalCapability("noReset", true);
            options.AddAdditionalCapability("deviceName", DEVICE_NAME);
            options.AddAdditionalCapability("platformVersion", "14.0");
            options.AddAdditionalCapability("automationName", "XCUITest");
            options.AddAdditionalCapability("udid", DEVICE_UDID);
            options.AddAdditionalCapability("xCodeOrgId", "7AAC4DGPCP");
            options.AddAdditionalCapability("xCodeSigningId", "iPhone Developer");
            options.AddAdditionalCapability("app", APP_PATH);
            return options;
        }

        public Uri AppiumServerUrl()
        {
            Uri url = new Uri(APPIUM_SERVER_HOST+":"+APPIUM_SERVER_PORT+"wd/hub");
            return url;
        }

        public IOSDriver<IOSElement> GetDriver()
        {
            Uri url = AppiumServerUrl();
            AppiumOptions options = IOSCapability();
            driver = new IOSDriver<IOSElement>(AppiumServerUrl(), options, TimeSpan.FromMinutes(4));
            return driver;
        }

        [OneTimeSetUp]
        public void InitiateDriver()
        {
            driver = GetDriver();
            driver.LaunchApp();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
            Console.WriteLine("Driver Initiated Succesfully");
            driver.Orientation = ScreenOrientation.Landscape;
            Console.WriteLine("Setting Device To Landscape Mode");
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            if (driver != null)
            {
                Console.WriteLine("Test Completed and Closing Driver");
                driver.CloseApp();
                driver.Quit();
                Console.WriteLine("Driver Closed and Application Exited !!!");
            }
        }

        [Test]
        public void TestStartApp()
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