using MyAxaBDD.GenericHelper;
using OpenQA.Selenium;

namespace MyAxaBDD.RoiMotorPages
{
    public class RoiMotorQteRetrievalPage : RoiMotorPageBase
    {
        //StepTwoPage 
        IWebElement chooseMethodforQuoteretrieval;
        IWebElement emailID;
        IWebElement day;
        IWebElement month;
        IWebElement year;
        IWebElement quoteReferenceNumber;
        IWebElement retrieveQteBtn;
        IWebElement regNum;
        public void ChooseMethodForRetrievingYourQuote(string retrivalMethod)
        {
            WaitForElementToBeDisplayed("Option");
            chooseMethodforQuoteretrieval = GetElementById("Option");
            SelectByVisibleText(chooseMethodforQuoteretrieval, retrivalMethod);
        }
        public void EnterEmailAddress(string inputEmailID)
        {
            ScrollToElement(GetElementById("EmailAddress"));
            WaitForElementToBeDisplayed("#EmailAddress");
            emailID = GetElementById("EmailAddress");
            TypeGivenValueInto(emailID, inputEmailID);
        }
        public void EnterDateOfBirth(string dd, string mm, string yy)
        {
            WaitForElementToBeDisplayed("#DateOfBirthDay");
            day = GetElementById("DateOfBirthDay");
            SelectByVisibleText(day, dd);

            month = GetElementById("DateOfBirthMonth");
            SelectByVisibleText(month, mm);

            year = GetElementById("DateOfBirthYear");
            SelectByVisibleText(year, yy);
        }

        public void EnterQuoteReferenceNumber(string qteNnumber)
        {
            WaitForElementToBeDisplayed("#QuoteNumber");
            quoteReferenceNumber = GetElementByCssSelector("#QuoteNumber");
            TypeGivenValueInto(quoteReferenceNumber, qteNnumber);
        }
        public void EnterRegistrationNumber(string enterRegNumber)
        {
            regNum = GetElementById("RegistrationNumber");
            TypeGivenValueInto(regNum, enterRegNumber);
        }

        public StepTwoPage ClickRetrieveQuoteButton()
        {
            retrieveQteBtn = GetElementById("btn-retrieveQuote");
            retrieveQteBtn.Click();
            return new StepTwoPage();
        }
    }
}
