using System;
using OpenQA.Selenium.Appium.iOS;
using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium;
using AventStack.ExtentReports;
using NUnit.Framework.Interfaces;
using AventStack.ExtentReports.Reporter;

namespace AppiumIOSFramework.Core
{
    public class Base : Reporter
    {
        public static IOSDriver<IOSElement> driver;

        public AppiumOptions IOSCapability()
        {
            AppiumOptions options = new AppiumOptions();
            options.AddAdditionalCapability("platformName", DEVICE_PLATFORM_NAME);
            options.AddAdditionalCapability("waitForDeviceTimeout", DEVICE_TIMEOUT);
            options.AddAdditionalCapability("derivedDataPath", DERIVED_DATA_PATH);
            options.AddAdditionalCapability("iosInstallPause", 10000);
            options.AddAdditionalCapability("usePrebuiltWDA", true);
            options.AddAdditionalCapability("resetOnSessionStartOnly", true);
            options.AddAdditionalCapability("autoAcceptAlerts", true);
            options.AddAdditionalCapability("deviceName", DEVICE_NAME);
            options.AddAdditionalCapability("platformVersion", DEVICE_PLATFORM_VERSION);
            options.AddAdditionalCapability("automationName", AUTOMATION_NAME);
            options.AddAdditionalCapability("udid", DEVICE_UDID);
            options.AddAdditionalCapability("xCodeOrgId", xCODE_TEAM_ID);
            options.AddAdditionalCapability("xCodeSigningId", xCODE_SIGN_ID);
            options.AddAdditionalCapability("app", APP_PATH);
            return options;
        }

        public Uri AppiumServerUrl()
        {
            Uri url = new Uri(APPIUM_SERVER_HOST+":"+APPIUM_SERVER_PORT+"/wd/hub");
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
    }
}