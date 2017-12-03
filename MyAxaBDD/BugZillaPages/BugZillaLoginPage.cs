using MyAxaBDD.GenericHelper;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAxaBDD.BugZillaPages
{
    public class BugZillaLoginPage: BugZillaPageBase
    {
        IWebElement loginPagedislay;
        IWebElement username;
        IWebElement password;
        IWebElement loginBtn;

        public void isLoginPageDisplayed()
        {
            loginPagedislay = GetElementByCssSelector("#title p");
            VerifyAnElementIsDisplayed(loginPagedislay);
        }
        public void EnterLoginDetails(string userID)
        {
            username = GetElementById("Bugzilla_login");
            TypeGivenValueInto(username, userID);
        }

        public void EnterPassword(string passwd)
        {
            password = GetElementById("Bugzilla_password");
            TypeGivenValueInto(password, passwd);
        }
        public BugZillaEnter_BugPage ClickLoginButon()
        {
            loginBtn = GetElementById("log_in");
            return new BugZillaEnter_BugPage();
        }
    }
}
