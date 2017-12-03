using MyAxaBDD.MyAxaPages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAxaBDD.GenericHelper
{
    public class PageBase : BaseClass
    {
        private IWebElement signOut;
        public static MyAxaLoginPage GivenINavigateToLoginPage()
        {
            LaunchUrl("https://secureweb.axa.ie/SelfService/Login/");

            return new MyAxaLoginPage();
        }

        public void ClickSignOutBtn()
        {
            ScrollToElement(".hero-banner");
            signOut = GetElementByCssSelector(".button-group .icon:nth-child(4)");
            signOut.Click();
        }
    }
}
