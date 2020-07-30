using System;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

namespace AppiumIOSFramework.Core
{
    public class Reporter : Config
    {
        public static ExtentReports extent;
        public static ExtentTest test;

        public void StartReporting()
        {
            var klov = new ExtentKlovReporter("project", "build");
            extent.AttachReporter(klov);
        }

        public ExtentTest CreateTest(string test_name)
        {
            return extent.CreateTest(test_name);
        }

    //     test.Fail("details",
	// MediaEntityBuilder.CreateScreenCaptureFromPath("screenshot.png").Build());
    }

    public class NewTest: Reporter
    {
        public ExtentTest Test;
        public NewTest(string test_name)
        {
            Test = extent.CreateTest(test_name);
        }

        public ExtentTest Node(string node_name)
        {
            return Test.CreateNode(node_name);
        }
    }
}
