using MyAxaBDD.GenericHelper;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAxaBDD.BugZillaPages
{
    public class BugZillaMainPage: BugZillaPageBase
    {
        IWebElement mainPage;
        IWebElement fileAbug;
        //IWebElement fileAbug;
        public void IsMainPageDisplayed()
        {
            mainPage = GetElementByCssSelector("#title p");
            VerifyAnElementIsDisplayed(mainPage);
        }
        public void IsFileABugLinkDisplayed()
        {
            fileAbug = GetElementByLinkText("File a Bug");
            VerifyAnElementIsDisplayed(fileAbug);
        }
        public BugZillaLoginPage ClickFileABugToGOTOLoginPage(string linkText)
        {
            fileAbug = GetElementByLinkText(linkText);
            fileAbug.Click();
            return new BugZillaLoginPage();
        }
    }
}
