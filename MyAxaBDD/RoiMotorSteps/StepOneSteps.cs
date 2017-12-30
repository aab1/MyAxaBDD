using MyAxaBDD.GenericHelper;
using MyAxaBDD.RoiMotorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace MyAxaBDD.MyAxaSteps
{
    [Binding]
    public sealed class StepOneSteps
    {
        private StepOnePage stepOnePage;
        private  StepTwoPage stepTwoPage;

        [Given(@"user is at ROI Motor DS")]
        public void GivenUserIsAtROIMotorDS()
        {
            stepOnePage = RoiMotorPageBase.NavigateToROIMotorDS();
        }

        [Given(@"motor DS Your Detail section is displayed")]
        public void GivenMotorDSYourDetailSectionIsDisplayed()
        {
            stepOnePage.isMotorDSDisplayed();
        }

        [When(@"I input name ""(.*)"" ""(.*)"" ""(.*)""")]
        public void WhenIInputName(string title, string firstName, string lastname)
        {
            stepOnePage.SelectTitle(title);
            stepOnePage.EnterFirstName(firstName);
            stepOnePage.EnterLastName(lastname);
        }

        [When(@"date of birth""(.*)"" ""(.*)"" ""(.*)""")]
        public void WhenDateOfBirth(string day, string month, string year)
        {
            stepOnePage.SelectBirthDay(day);
            stepOnePage.SelectBirthMonth(month);
            stepOnePage.SelectBirthYear(year);
        }

        [When(@"I enter gender ""(.*)"" and email""(.*)""")]
        public void WhenIEnterGenderAndEmail(string gender, string email)
        {
            stepOnePage.ClickGender(gender);
            stepOnePage.EnterEmail(email);
        }

        [When(@"I input phone number""(.*)"" ""(.*)""")]
        public void WhenIInputPhoneNumber(string areaCode, string phoneNumber)
        {
            stepOnePage.SelectAreaCode(areaCode);
            stepOnePage.EnterPhoneNumber(phoneNumber);
        }

        [When(@"I enter adress with eircode ""(.*)""")]
        public void WhenIEnterAdressWithEircode(string eircode)
        {
            stepOnePage.EnterEircode(eircode);
            stepOnePage.ClickConfirmAddress();
            stepOnePage.AddressCheckBox();
        }

        [When(@"I selected ""(.*)"" ""(.*)"" ""(.*)""")]
        public void WhenISelected(string houseHold, string employmentStatus, string occupation)
        {
            stepOnePage.SelectHouseHoldType(houseHold);
            stepOnePage.SelectEmploymentStatus(employmentStatus);
            stepOnePage.SelectOccupation(occupation);
            stepOnePage.ClickContinueBtnOnDetailsSection();
        }

        [When(@"I complete Your car section ""(.*)"" ""(.*)""")]
        public void WhenICompleteYourCarSection(string carRegNumber, string millage)
        {
            stepOnePage.EnterCarReg(carRegNumber);
            stepOnePage.clickConfirmCarButton();
            stepOnePage.IsThisTheCorrectCarClickYes();
            stepOnePage.WillThisCarBeUsedForBusinessPurpose_ClickNO();
            stepOnePage.WillThisCarBeUsedForCommutingToWork_ClickNo();
            stepOnePage.MilleagePerYear(millage);
            stepOnePage.ClickContinueBtnOnYourCarSection();
        }

        [When(@"I complete driving history ""(.*)""\t""(.*)"" ""(.*)"" ""(.*)""")]
        public void WhenICompleteDrivingHistory(string drivingLicence, string drivingLicenceAge, string recentInsurance, string numOfClaimFreeYears)
        {
            stepOnePage.SelectCurrentDrivingLicence(drivingLicence);
            stepOnePage.SelectDrivingLicenceAge(drivingLicenceAge);
            stepOnePage.SelectRecentInsurance(recentInsurance);
            stepOnePage.SelectNumOfClaimFreeYears(numOfClaimFreeYears);
            stepOnePage.ClickDrivingHistorySectionContinueBtn();
        }

        [When(@"I added NO additional driver and claims")]
        public void WhenIAddedNOAdditionalDriverAndClaims()
        {
            stepOnePage.AdditionalDriver_ClickNO();
            stepOnePage.AdditonalDriverContinueBtn();
            stepOnePage.HaveYouHadAnyClaims_ClickNo();
            stepOnePage.ClickBtnClaims();
        }

        [When(@"I complete Your cover section")]
        public void WhenICompleteYourCoverSection()
        {
            stepOnePage.ClickNoButtonWhenAskedHaveAnotherPolicyInsuredWithAAXA();
            stepOnePage.PayInFullBtn();
            stepOnePage.TickAgreeTermsCheckBox();
            stepTwoPage = stepOnePage.ClickGetQuoteBtn();
        }

       

    }
}
