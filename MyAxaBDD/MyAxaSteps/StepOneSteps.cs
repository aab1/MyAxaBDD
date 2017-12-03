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
        public void WhenIEnterGenderAndEmail(string p0, string p1)
        {
            
        }

        [When(@"I input phone number""(.*)"" ""(.*)""")]
        public void WhenIInputPhoneNumber(int p0, int p1)
        {
            
        }

        [When(@"I enter adress with eircode ""(.*)""")]
        public void WhenIEnterAdressWithEircode(string p0)
        {
            
        }

        [When(@"I selected ""(.*)"" ""(.*)"" ""(.*)""")]
        public void WhenISelected(string p0, string p1, string p2)
        {
            
        }

        [When(@"I complete Your car section ""(.*)"" ""(.*)""")]
        public void WhenICompleteYourCarSection(string p0, string p1)
        {
            
        }

        [When(@"I complete driving history ""(.*)""\t""(.*)"" ""(.*)"" ""(.*)""")]
        public void WhenICompleteDrivingHistory(string p0, string p1, string p2, string p3)
        {
            
        }

        [When(@"I added NO additional driver and claims")]
        public void WhenIAddedNOAdditionalDriverAndClaims()
        {
            
        }

        [When(@"I complete Your cover section")]
        public void WhenICompleteYourCoverSection()
        {
           ;
        }

        [When(@"Step two is displayed")]
        public void WhenStepTwoIsDisplayed()
        {
            
        }

    }
}
