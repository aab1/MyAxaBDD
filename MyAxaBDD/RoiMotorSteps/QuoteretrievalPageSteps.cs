using MyAxaBDD.GenericHelper;
using MyAxaBDD.RoiMotorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace MyAxaBDD.RoiMotorSteps
{
    [Binding]
    public sealed class QuoteretrievalPageSteps
    {
        private RoiMotorQteRetrievalPage qteRetrivalPage;
        StepTwoPage stepTwoPage;

        [When(@"I navigate to the quote retrieval page")]
        public void WhenINavigateToTheQuoteRetrievalPage()
        {
            qteRetrivalPage = RoiMotorPageBase.NavigateToRoiMotorQuoteRetrievalPage();
        }

        [When(@"I choose ""(.*)"" method for retrieving the quote")]
        public void WhenIChooseMethodForRetrievingTheQuote(string inputRetrievalMethod)
        {
            qteRetrivalPage.ChooseMethodForRetrievingYourQuote(inputRetrievalMethod);
        }

        [When(@"I input the quote details")]
        public void WhenIInputTheQuoteDetails()
        {
            qteRetrivalPage.EnterEmailAddress(StepOnePage.GetEmail());
            qteRetrivalPage.EnterDateOfBirth(StepOnePage.GetDayFromBirthDate(),StepOnePage.GetMonthFromBirthDate(),StepOnePage.GetYearFromBirthDate());
            qteRetrivalPage.EnterQuoteReferenceNumber(StepTwoPage.GetQuoteReferenceNumber());
        }

        [Then(@"The quote is retrieved successfully")]
        public void ThenTheQuoteIsRetrievedSuccessfully()
        {
            stepTwoPage = qteRetrivalPage.ClickRetrieveQuoteButton();
        }
    }
}
