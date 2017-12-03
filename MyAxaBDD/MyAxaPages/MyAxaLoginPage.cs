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
    public class MyAxaLoginPage : PageBase
    {
        private IWebElement manageYourPolicy;
        private IWebElement emailAddress;
        private IWebElement password;
        private IWebElement signIn;
       
        public void AndIamOnLoginPage()
        {
            manageYourPolicy = GetElementByCssSelector("#main > h1.h1.heading.hidden-min.hidden-xs");
            Assert.True(manageYourPolicy.Displayed, "MyAxa Login page is not displayed!");
        }
        public void EnterEmailID(string emailID)
        {
            emailAddress = GetElementById("EmailAddress");
            emailAddress.Clear();
            emailAddress.SendKeys(emailID);
        }
        public void EnterPassword(string passwd)
        {
            password = GetElementById("Password");
            password.Clear();
            password.SendKeys(passwd);
        }

        public MyAxaOverviewPage ClickToSignInToMyAxa()
        {
            signIn = GetElementById("Login-btn");
            signIn.Click();
            WaitUntilUrlContainsASpecifiedWord("Overview");
            return new MyAxaOverviewPage();
            
        }

       
    }
}
