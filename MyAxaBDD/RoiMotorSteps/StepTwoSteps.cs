
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

    }
}
