using MyAxaBDD.GenericHelper;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAxaBDD.MyAxaPages
{
    public class VerificationPage : MyAxaPageBase
    {
        IWebElement veriCode;
        IWebElement verifybtn;
        public void InputVerificationCode(string vCode)
        {
            WaitForElementToBeDisplayed("#VerificationCode");
            veriCode = GetElementByCssSelector("#VerificationCode");
            TypeGivenValueInto(veriCode, vCode);
        }

        public MyAxaOverviewPage ClickVerifyBtn()
        {
            verifybtn = GetElementByCssSelector("#verification-form > fieldset > ul > li.Bn > div > div > button");
            WaitForElementToBeClickable(verifybtn);
            verifybtn.Click();
            return new MyAxaOverviewPage();
        }
    }
}
