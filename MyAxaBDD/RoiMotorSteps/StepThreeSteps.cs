using MyAxaBDD.RoiMotorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace MyAxaBDD.MyAxaSteps
{
    [Binding]
    public sealed class StepThreeSteps
    {
        StepTwoPage stepTwoPage = new StepTwoPage();
        private StepThreePage stepThreePage;
        private RealexpaymentsPage realexPage;

        [When(@"Step three is displayed")]
        public void WhenStepThreeIsDisplayed()
        {
            stepThreePage = stepTwoPage.VerifyThatStepThreeIsDisplayed();
        }

        [When(@"I Complete licence details ""(.*)"" ""(.*)"" ""(.*)""")]
        public void WhenICompleteLicenceDetails(string day, string month, string year)
        {
            stepThreePage.DateLicenceWasIssued(day, month, year);
            stepThreePage.ClickNoToPenaltyPoint();
            stepThreePage.ClickNoToLicenceDetailsILD();
            stepThreePage.LicenceDetailSectionContinueBtn();
        }

        [When(@"I Complete Insurance details section ""(.*)""")]
        public void WhenICompleteInsuranceDetailsSection(string date)
        {
            stepThreePage.EnterExistingPolicyExpiryDate(date);
            stepThreePage.InsuranceDetailsSectionILD();
            stepThreePage.ClickInsuranceDetailsContinueBtn();
        }
        [When(@"I input car value ""(.*)"" and date ""(.*)"" ""(.*)"" ""(.*)"" to complete Car details section")]
        public void WhenIInputCarValueAndDateToCompleteCarDetailsSection(string carValue, string day, string month, string year)
        {
            stepThreePage.ValueOfCar(carValue);
            stepThreePage.EnterCarPurchaseDate(day, month, year);
            stepThreePage.CarDetailsILD();
            stepThreePage.ClickCarDetailsSectionContinueBtn();
        }
       
       

       


    }
}
