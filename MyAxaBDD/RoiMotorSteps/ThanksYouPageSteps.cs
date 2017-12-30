using MyAxaBDD.RoiMotorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace MyAxaBDD.RoiMotorSteps
{
    [Binding]
    public sealed class ThanksYouPageSteps
    {
        private ThankYouPage thankYouPage;
        RealexpaymentsPage realexPage = new RealexpaymentsPage();

        [Then(@"Policy is successfully incepted")]
        public void ThenPolicyIsSuccessfullyIncepted()
        {
            thankYouPage = realexPage.ClickPayNow();
            thankYouPage.VerifyThatPolicyNumberIsDisplayed();
        }
    }
}
