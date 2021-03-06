﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.2.0.0
//      SpecFlow Generator Version:2.2.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace MyAxaBDD.Specifications
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("QuotesAndRetrieval")]
    public partial class QuotesAndRetrievalFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "QuotesAndRetrieval.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "QuotesAndRetrieval", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 3
#line 4
  testRunner.Given("user is at ROI Motor DS", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 5
  testRunner.And("motor DS Your Detail section is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Save And Retrieve Motor DS Quote")]
        [NUnit.Framework.TestCaseAttribute("Mr", "quote", "saved", "12", "05 - May", "1980", "Female", "quote1@axa-uat.ie", "087", "0879567812", "Yes", "K32VP28", "Rented Accommodation", "Employed", "Accountant", "10D262", "Up to 5,000 km", "ROI (Full)", "9 years", "Insured in own name", "6+ Years Claims Free Driving", "Email, date of birth & quote reference number", null)]
        public virtual void SaveAndRetrieveMotorDSQuote(
                    string title, 
                    string firstName, 
                    string lastName, 
                    string dayOfBirth, 
                    string birthMonth, 
                    string birthYear, 
                    string gender, 
                    string email, 
                    string areaCode, 
                    string phoneNumber, 
                    string eircodeYesNo, 
                    string eircode, 
                    string household, 
                    string employmentStatus, 
                    string occupation, 
                    string carRegNum, 
                    string kilometersDriven, 
                    string drivingLicence, 
                    string licenceAge, 
                    string recentInsurance, 
                    string numOfClaimFreeYears, 
                    string methodforQuoteretrieval, 
                    string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Save And Retrieve Motor DS Quote", exampleTags);
#line 7
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line 9
   testRunner.Given("user is at ROI Motor DS", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 10
   testRunner.And("motor DS Your Detail section is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
   testRunner.When(string.Format("I input name \"{0}\" \"{1}\" \"{2}\"", title, firstName, lastName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 12
   testRunner.And(string.Format("date of birth\"{0}\" \"{1}\" \"{2}\"", dayOfBirth, birthMonth, birthYear), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
   testRunner.And(string.Format("I enter gender \"{0}\" and email\"{1}\"", gender, email), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
   testRunner.And(string.Format("I input phone number\"{0}\" \"{1}\"", areaCode, phoneNumber), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
   testRunner.And(string.Format("I enter adress with eircode \"{0}\"", eircode), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 16
   testRunner.And(string.Format("I selected \"{0}\" \"{1}\" \"{2}\"", household, employmentStatus, occupation), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 17
   testRunner.And(string.Format("I complete Your car section \"{0}\" \"{1}\"", carRegNum, kilometersDriven), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 18
   testRunner.And(string.Format("I complete driving history \"{0}\"\t\"{1}\" \"{2}\" \"{3}\"", drivingLicence, licenceAge, recentInsurance, numOfClaimFreeYears), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
   testRunner.And("I added NO additional driver and claims", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
   testRunner.And("I complete Your cover section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
  testRunner.And("Step two is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 23
  testRunner.And("I proceed to save the quote", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 24
  testRunner.Then("The quote is saved successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 25
  testRunner.When("I navigate to the quote retrieval page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 26
  testRunner.And(string.Format("I choose \"{0}\" method for retrieving the quote", methodforQuoteretrieval), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
  testRunner.And("I input the quote details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
  testRunner.Then("The quote is retrieved successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
