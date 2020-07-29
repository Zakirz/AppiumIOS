using System;
using System.Collections.Generic;
using OpenQA.Selenium.Appium.iOS;

namespace AppiumIOSFramework.Core
{
    public class AppiumHelpers: Base
    {

        public IOSElement FindElement(string eleLocator)
        {
            string[] locate = eleLocator.Split("###");
            string locator = locate[1];
            string by = locate[0];
            IOSElement element = null;
            try{
                if (by.ToLower() == "id")
                {
                    element = driver.FindElementById(locator);
                    return element;
                }
                else if (by.ToLower() == "xpath")
                {
                    element = driver.FindElementByXPath(locator);
                    return element;
                }
                else if (by.ToLower() == "class")
                {
                    element = driver.FindElementByClassName(locator);
                    return element;
                }
                else if (by.ToLower() == "accessid")
                {
                    element = driver.FindElementByAccessibilityId(locator);
                    return element;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception in Locator " + locator + "  " + e.Message);
            }
            return element;
        }

        public IOSElement FindElements(string by, string locator)
        {
            IEnumerable<IOSElement> elements = null;
            try
            {
                if (by.ToLower() == "id")
                {
                    elements = driver.FindElementsById(locator);
                    return (IOSElement)elements;
                }
                else if (by.ToLower() == "xpath")
                {
                    elements = driver.FindElementsByXPath(locator);
                    return (IOSElement)elements;
                }
                else if (by.ToLower() == "class")
                {
                    elements = driver.FindElementsByClassName(locator);
                    return (IOSElement)elements;
                }
                else if (by.ToLower() == "accessid")
                {
                    elements = driver.FindElementsByAccessibilityId(locator);
                    return (IOSElement)elements;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception in Locator "+locator+"  "+ e.Message);
            }
            return (IOSElement)elements;
        }

        public void ClickOn(string locator)
        {
            try
            {
                this.FindElement(locator).Click();
            }
            catch (Exception e)
            {

                Console.WriteLine("Exception in Clicking " + locator + "  " + e.Message);
            }
        }

        public void EnterText(string locator, string toTypeText)
        {
            try
            {
                this.FindElement(locator).SendKeys(toTypeText);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception in Type Text " + locator + "  " + e.Message);
            }
        }

        public bool IsDisplayed(string locator)
        {
            bool displayed = false;
            try
            {
                displayed = this.FindElement(locator).Displayed;
                return displayed;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception in Displayed " + locator + "  " + e.Message);
            }
            return displayed;
        }

    }
}