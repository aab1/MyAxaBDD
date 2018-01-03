
using MyAxaBDD.RoiMotorPages;
using TechTalk.SpecFlow;

namespace MyAxaBDD.MyAxaSteps
{
    [Binding]
    public sealed class StepTwoSteps
    {
        private StepTwoPage stepTwoPage;
         StepOnePage stepOnePage = new StepOnePage();
        private StepThreePage stepThreePage;

        [When(@"Step two is displayed")]
        public void WhenStepTwoIsDisplayed()
        {
            stepTwoPage = stepOnePage.VerifythatStepTwoUrlIsDisplayed();
            stepTwoPage.VerifyThatStepTwoIsDisplayed();
        }

        [When(@"I click Buy Now Button")]
        public void WhenIClickBuyNowButton()
        {
            stepThreePage = stepTwoPage.ClickBuyNowBtn();
        }
        //scenario two methods
        [When(@"I switch to TPFT")]
        public void WhenISwitchToTPFT()
        {
            stepTwoPage.ClickSwitchToTPFT();
        }

        [When(@"I add all addons")]
        public void WhenIAddAllAddons()
        {
            stepTwoPage.AddGlassBreakage();
            stepTwoPage.AddInjuryCover();
            stepTwoPage.AddCarAndKeyRescue();
            stepTwoPage.AddLegalExpenses();
            stepTwoPage.AddOpenDriving();
            stepTwoPage.AddCarHireReplacementPlus();
            stepTwoPage.AddProtectedNCD();
            stepTwoPage.ClickUpdateYourQuote();
        }
        [When(@"I click continue to Buy Button")]
        public void WhenIClickContinueToBuyButton()
        {
            stepThreePage = stepTwoPage.ClickContinueToBuy();
        }

        //save quote methods
        [When(@"I proceed to save the quote")]
        public void WhenIProceedToSaveTheQuote()
        {
            stepTwoPage.ClickSaveQuoteBtn();
        }

        [Then(@"The quote is saved successfully")]
        public void ThenTheQuoteIsSavedSuccessfully()
        {
            stepTwoPage.VerifyThatQuoteIsSavedSucessFully();
        }


    }
}
