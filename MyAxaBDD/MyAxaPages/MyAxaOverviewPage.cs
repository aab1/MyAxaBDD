using MyAxaBDD.GenericHelper;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAxaBDD.MyAxaPages
{
    public class MyAxaOverviewPage : MyAxaPageBase
    {
        private IWebElement welcomeMsg;
        
        public void OverviewPageIsDisplayed()
        {
            WaitForElementToBeDisplayed("#welcome-message");
            welcomeMsg = GetElementById("welcome-message");
            Assert.True(welcomeMsg.Displayed, "Overview Page is not displayed!");
        }

       
    }
}
