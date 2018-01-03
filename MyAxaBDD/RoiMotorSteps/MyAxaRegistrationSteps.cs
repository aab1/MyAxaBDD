using MyAxaBDD.MyAxaPages;
using MyAxaBDD.RoiMotorPages;
using TechTalk.SpecFlow;

namespace MyAxaBDD.RoiMotorSteps
{
    [Binding]
    public sealed class MyAxaRegistrationSteps
    {
        private MyAxaRegistrationPage registrationPage;
        ThankYouPage thankYouPage = new ThankYouPage();

        [When(@"I complete your details section with a valid password: ""(.*)""")]
        public void WhenICompleteYourDetailsSectionWithAValidPassword(string password)
        {
            registrationPage = thankYouPage.ClickSignUpNowButton();
            registrationPage.InputPassword(password);
            registrationPage.TickTermOfUseCheckBox();
        }

       


    }
}
