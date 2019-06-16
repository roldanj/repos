using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;

namespace BuildDemo2017
{
    [TestClass]
    public class TouchTest
    {

        protected const string WindowApplicationDriverUrl = "http://127.0.0.1:4723/";
        protected static WindowsDriver<WindowsElement> TestSession;
        const string pathPaint = "c:\\windows\\system32\\mspaint.exe";
        const string pathEdge = "Microsoft.MicrosoftEdge_8wekyb3d8bbwe!MicrosoftEdge";
        const string pathIE = "C:\\Program Files\\internet explorer\\iexplore.exe";

        [ClassInitialize]
        public static void Setup(TestContext context)
        {
            // Launch the app
            DesiredCapabilities appCapabilities = new DesiredCapabilities();
            appCapabilities.SetCapability("deviceName", "WindowsPC");
            appCapabilities.SetCapability("app", pathIE);
            TestSession = new WindowsDriver<WindowsElement>(new Uri(WindowApplicationDriverUrl), appCapabilities);
            Assert.IsNotNull(TestSession);

            // Have Edge browse nav to the CH9 the BUILD site
           // WindowsElement addressBox = TestSession.FindElementByAccessibilityId("addressEditBox");
            WindowsElement addressBox = TestSession.FindElementByName("Address and search using Bing");
            addressBox.Click();
            addressBox.SendKeys("https://channel9.msdn.com");
            System.Threading.Thread.Sleep(3000);
            TestSession.Keyboard.PressKey(OpenQA.Selenium.Keys.Enter);
            System.Threading.Thread.Sleep(3000);
        }

        [ClassCleanup]
        public static void TearDown()
        {
            if (TestSession != null)

            {
                TestSession.Dispose();
                TestSession = null;
            }
        }
        [TestMethod]
        public void TestSingleTouch()
        {
            var tso = new RemoteTouchScreen(TestSession);
            tso.Down(600, 700);
            tso.Up(600, 300);
            System.Threading.Thread.Sleep(2000);
        }


        [TestMethod]
        public void TestMultiTouch()
        {

            TestSession.Zoom(500, 500);
            TestSession.Pinch(700, 800);
            System.Threading.Thread.Sleep(2000);

        }
    }
}
