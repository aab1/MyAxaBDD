using MyAxaBDD.RoiMotorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace MyAxaBDD.RoiMotorSteps
{
    [Binding]
    public sealed class RealexPageSteps
    {
        private RealexpaymentsPage realexPage;
        StepThreePage stepThreePage = new StepThreePage();
        ThankYouPage thankYouPage = new ThankYouPage();

        [When(@"I proceed to pay in full")]
        public void WhenIProceedToPayInFull()
        {
            stepThreePage.ConfirmDetailsSectionILDCheckBox();
            realexPage = stepThreePage.ClickPayInFullBtn();
        }


        [When(@"I enter my credit card details""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void WhenIEnterMyCreditCardDetails(string cNum, string mm, string yy, string cvv, string cName)
        {
            realexPage.EnterCreditCardNumber(cNum);
            realexPage.EnterCreditCardExpiryDate(mm, yy);
            realexPage.EnterCreditCardSecurityCode(cvv);
            realexPage.EnterCardholderName(cName);
            //thankYouPage = realexPage.ClickPayNow();
        }

    }
}
