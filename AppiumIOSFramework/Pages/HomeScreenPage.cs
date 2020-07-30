using AppiumIOSFramework.Application;
using NUnit.Framework;

namespace AppiumIOSFramework.Pages
{
    class HomeScreenPage:App
    {
        public string DCMLink = "accessid###Image3912. This is a Link. ";

        public void OpenDCMLInk()
        {
            ClickOn(DCMLink);
        }
    }
}