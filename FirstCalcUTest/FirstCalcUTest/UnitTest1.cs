using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;

namespace FirstCalcUTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DesiredCapabilities desiredCapabilities = new DesiredCapabilities();
           // desiredCapabilities.SetCapability("app", "Microsoft.WindowsCalculator_8wekyb3d8bbwe!App");
            desiredCapabilities.SetCapability("app", @"C:\Program Files\Wayne\NMC\bin\NMC.exe");
            var winDriver = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723/"), desiredCapabilities);

            SetParent();


            winDriver.FindElementByClassName("File");
           // winDriver.FindElementByWindowsUIAutomation("File");
            /*
            winDriver.FindElementByName("Eight").Click();
            winDriver.FindElementByName("Six").Click();
            winDriver.FindElementByName("Seven").Click();
            winDriver.FindElementByName("Five").Click();
            winDriver.FindElementByName("Three").Click();
            winDriver.FindElementByName("Zero").Click();
            winDriver.FindElementByName("Nine").Click();
*/

        }
    }
}
