using MyAxaBDD.GenericHelper;
using MyAxaBDD.MyAxaPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace MyAxaBDD.MyAxaSteps
{
    [Binding]
    public sealed class LoginSteps
    {
        private MyAxaLoginPage loginPage;
        private MyAxaOverviewPage overviewPage;

        [Then(@"the myAxa homepage is displayed")]
        [Given(@"I navigate to myAxa homepage")]
        public void GivenINavigateToMyAxaHomepage()
        {
            loginPage = PageBase.GivenINavigateToLoginPage();
            loginPage.AndIamOnLoginPage();
        }

        [Given(@"I enter correct login details")]
        public void GivenIEnterCorrectLoginDetails()
        {
            loginPage.EnterEmailID();
            loginPage.EnterPassword();
        }

        [When(@"I Click signIn")]
        public void WhenIClickSignIn()
        {
            overviewPage = loginPage.ClickToSignInToMyAxa();
        }

        [Then(@"the overview page is displayed")]
        public void ThenTheOverviewPageIsDisplayed()
        {
            overviewPage.OverviewPageIsDisplayed();
        }

        [When(@"I click signOut")]
        public void WhenIClickSignOut()
        {
            overviewPage.ClickSignOutBtn();
        }

        

    }
}
