using MyAxaBDD.MyAxaPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace MyAxaBDD.RoiMotorSteps
{
    [Binding]
    public sealed class MyAxaOverviewPageSteps
    {
        private MyAxaOverviewPage overviewPage;
        VerificationPage verificationPage = new VerificationPage();

        [Then(@"registration is successful")]
        public void ThenRegistrationIsSuccessful()
        {
            overviewPage = verificationPage.ClickVerifyBtn();
            overviewPage.OverviewPageIsDisplayed();
        }
    }
}
