using MyAxaBDD.GenericHelper;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAxaBDD.RoiMotorPages
{
    public class ThankYouPage : RoiMotorPageBase
    {
        IWebElement policyNumber;
        public void VerifyThatPolicyNumberIsDisplayed()
        {
            WaitUntilUrlContainsASpecifiedWord("Step4");
            WaitForElementToBeDisplayed("#main-content-wrapper > div > div > div > div.col-sm-6.col-sm-push-6 > div:nth-child(4) > span");
            policyNumber = GetElementByCssSelector("#main-content-wrapper > div > div > div > div.col-sm-6.col-sm-push-6 > div:nth-child(4) > span");
            string actualpolicyNumber = policyNumber.Text;
            Assert.IsNotEmpty(actualpolicyNumber,"Policy number is NOT displayed!");
        }
    }
}
