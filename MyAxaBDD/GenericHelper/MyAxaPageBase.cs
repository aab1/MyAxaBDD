using MyAxaBDD.MyAxaPages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAxaBDD.GenericHelper
{
    public class MyAxaPageBase : BaseClass
    {
        private IWebElement signOut;
        private IWebElement banner;
        public static MyAxaLoginPage GivenINavigateToLoginPage()
        {
            LaunchUrl("https://secureweb.axa.ie/SelfService/Login/");

            return new MyAxaLoginPage();
        }

        public void ClickSignOutBtn()
        {
            banner = GetElementByCssSelector(".hero-banner");
            ScrollToElement(banner);
            signOut = GetElementByCssSelector(".button-group .icon:nth-child(4)");
            signOut.Click();
        }
    }
}
