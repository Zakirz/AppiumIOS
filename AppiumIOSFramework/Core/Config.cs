using OpenQA.Selenium.Appium;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Service;

namespace AppiumIOSFramework.Core
{
    public class Config
    {
        public string APP_PATH = Path.Combine("/Users/INDIUM/Downloads/KAM.test.qa.ipa");
        public string DEVICE_PLATFORM_NAME = "iOS";
        public string DEVICE_PLATFORM_VERSION = "14.0";
        public string DEVICE_NAME = "ISILPAD16";
        public string DEVICE_UDID = "2c326aa14c8d596509a090f6163c6a5a8e9a9090";
        public string AUTOMATION_NAME = "XCUITest";
        public string DERIVED_DATA_PATH = Path.Combine("/Users/INDIUM/Library/Developer/Xcode/DerivedData/WebDriverAgent-alwvnomvwrdtzoaxbbkniqrpcdpp");
        public string APPIUM_SERVER_HOST = "http://localhost";
        public string APPIUM_SERVER_PORT = "4723";
        public string WEBDRIVER_SERVER_PORT = "8100";
        public int DEVICE_TIMEOUT = 120000;
        public int ELEMENT_TIMEOUT = 30;
        public string xCODE_TEAM_ID = "7AAC4DGPCP";
        public string xCODE_SIGN_ID = "iPhone Developer";
    }
}