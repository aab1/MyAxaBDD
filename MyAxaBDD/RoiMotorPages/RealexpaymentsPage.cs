using MyAxaBDD.GenericHelper;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAxaBDD.RoiMotorPages
{
    public class RealexpaymentsPage : RoiMotorPageBase
    {
        IWebElement crediCardNum;
        IWebElement month;
        IWebElement year;
        IWebElement cvv;
        IWebElement cardHolderName;
        IWebElement payNowBtn;

        public void VerifyThatRealexPageisDisplayed()
        {
            WaitUntilUrlContainsASpecifiedWord("realexpayments");
            string title = driver.Title;
            VerifyPageTitle("Payment Details",title, "This is not the correct Realex page!!");
        }
        public void EnterCreditCardNumber(string creditCdNum)
        {
            WaitForElementToBeDisplayed("#pas_ccnum");
            crediCardNum = GetElementById("pas_ccnum");
            TypeGivenValueInto(crediCardNum, creditCdNum);
        }
        public void EnterCreditCardExpiryDate(string mm, string yy)
        {
            month = GetElementById("pas_ccmonth");
            TypeGivenValueInto(month, mm);
            year = GetElementById("pas_ccyear");
            TypeGivenValueInto(year, yy);
        }
        public void EnterCreditCardSecurityCode(string sCode)
        {
            cvv = GetElementById("pas_cccvc");
            TypeGivenValueInto(cvv, sCode);
        }
        public void EnterCardholderName(string name)
        {
            cardHolderName = GetElementById("pas_ccname");
            TypeGivenValueInto(cardHolderName, name);
        }
        public ThankYouPage ClickPayNow()
        {
            ScrollToTheButtomOfAPage();
            payNowBtn = GetElementById("rxp-primary-btn");
            payNowBtn.Click();
            return new ThankYouPage();
        }
    }
}
