using MyAxaBDD.GenericHelper;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAxaBDD.MyAxaPages
{
    public class MyAxaRegistrationPage : MyAxaPageBase
    {
        IWebElement password;
        IWebElement termOfUse;
        IWebElement registerBtn;

        public void InputPassword(string pword)
        {
            password = GetElementById("Password");
            TypeGivenValueInto(password, pword);
        }

        public void TickTermOfUseCheckBox()
        {
            ScrollToElement(password);
            termOfUse = GetElementById("agree-terms-label");
            termOfUse.Click();
        }
        public VerificationPage ClickRegisterBtn()
        {
            registerBtn = GetElementByCssSelector("#login-details > ul > li.Bn > div > div > button");
            registerBtn.Click();
            return new VerificationPage();
        }
    }
}
