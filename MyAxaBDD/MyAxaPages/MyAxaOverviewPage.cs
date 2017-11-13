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
    public class MyAxaOverviewPage : PageBase
    {
        private IWebElement userlogo;
        
        public void OverviewPageIsDisplayed()
        {
            userlogo = GetElementById("user-menu");
            Assert.True(userlogo.Displayed, "Overview Page is not displayed!");
        }

       
    }
}
