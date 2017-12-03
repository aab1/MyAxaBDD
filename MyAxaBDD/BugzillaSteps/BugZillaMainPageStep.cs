using MyAxaBDD.BugZillaPages;
using MyAxaBDD.GenericHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace MyAxaBDD.BugzillaSteps
{
    [Binding]
    public sealed class BugZillaMainPageStep
    {
        private BugZillaMainPage mainPage;
        private BugZillaLoginPage loginpage;
        private BugZillaEnter_BugPage enterBugPage;

        [Given(@"User is at Bugzilla MainPage")]
        public void GivenUserIsAtBugzillaMainPage()
        {
            mainPage = BugZillaPageBase.NavigateToBuZillaMainPage();
            mainPage.IsMainPageDisplayed();
        }

        [Given(@"File a Bug should be visible")]
        public void GivenFileABugShouldBeVisible()
        {
            mainPage.IsFileABugLinkDisplayed();
        }

        [When(@"I click on a ""(.*)"" link to navigate login page")]
        public void WhenIClickOnALinkToNavigateLoginPage(string linkText)
        {
            loginpage = mainPage.ClickFileABugToGOTOLoginPage(linkText);
        }


        [Then(@"user should be at login page with title ""(.*)""")]
        public void ThenUserShouldBeAtLoginPageWithTitle(string p0)
        {
            loginpage.isLoginPageDisplayed();
        }

        [When(@"I provide the ""(.*)"",""(.*)"" and click on login button")]
        public void WhenIProvideTheAndClickOnLoginButton(string username, string password)
        {
            loginpage.EnterLoginDetails(username);
            loginpage.EnterPassword(password);
            enterBugPage = loginpage.ClickLoginButon();
        }

        [Then(@"user should be at enter bug page with title ""(.*)""")]
        public void ThenUserShouldBeAtEnterBugPageWithTitle(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I provide the ""(.*)"" , ""(.*)"" , ""(.*)"" and ""(.*)""")]
        public void WhenIProvideTheAnd(string p0, string p1, string p2, string p3)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I click on submit button in page")]
        public void WhenIClickOnSubmitButtonInPage()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Bug should get created")]
        public void ThenBugShouldGetCreated()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"i click on logout button on bug detail page")]
        public void WhenIClickOnLogoutButtonOnBugDetailPage()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"user should be logged out and should be at homepage")]
        public void ThenUserShouldBeLoggedOutAndShouldBeAtHomepage()
        {
            ScenarioContext.Current.Pending();
        }


    }
}
