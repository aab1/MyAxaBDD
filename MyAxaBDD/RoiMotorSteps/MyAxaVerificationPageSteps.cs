using MyAxaBDD.MyAxaPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace MyAxaBDD.RoiMotorSteps
{
    [Binding]
    public sealed class MyAxaVerificationPageSteps
    {
        private VerificationPage verificationPage;
        MyAxaRegistrationPage registrationPage = new MyAxaRegistrationPage();

        [When(@"I Input verification code: ""(.*)""")]
        public void WhenIInputVerificationCode(string vCode)
        {
            verificationPage = registrationPage.ClickRegisterBtn();
            verificationPage.InputVerificationCode(vCode);
        }
    }
}
