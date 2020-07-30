using AppiumIOSFramework.Application;
using NUnit.Framework;

namespace AppiumIOSFramework.Pages
{
    class CRSummaryPage:App
    {
        public string SearchHCPBtn = "accessid###Image9273. This is a Link. ";

        public void ClickSearch() => ClickOn(SearchHCPBtn);
        public bool SearchButtonDisplayed() => IsDisplayed(SearchHCPBtn);
    }
}