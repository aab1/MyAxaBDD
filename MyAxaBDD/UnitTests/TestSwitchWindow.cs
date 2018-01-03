using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAxaBDD.UnitTests
{
    [TestFixture]
    public class TestSwitchWindow :BaseClass
    {
        [Test, Ignore("This is just a unit test")]
        public void TestSwithWindowmethod()
        {
            LaunchBrowser("Chrome");
            LaunchUrl("https://www.w3schools.com/js/js_popup.asp");
            IWebElement btn = GetElementByXpath("//div[@id='main']/descendant::a[position()=3]");
            //The click Opens a new tab
            btn.Click();
           
            SwitchToWindow(1);
            LaunchUrl("https://www.w3schools.com/js/js_popup.asp");
            btn = GetElementByXpath("//div[@id='main']/descendant::a[position()=3]");
            btn.Click();
            SwitchToWindow(2);
            SwitchToParentWindow();
            CloseBrowser();
        }
    }
}
