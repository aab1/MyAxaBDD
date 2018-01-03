using MyAxaBDD.GenericHelper;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyAxaBDD.RoiMotorPages
{
    public class StepThreePage : RoiMotorPageBase
    {
        IWebElement day;
        IWebElement month;
        IWebElement year;
        IWebElement penaltyPoint;
        IWebElement licenceDetILD1;
        IWebElement licenceDetILD2;
        IWebElement ldContinueBtn;
        IWebElement existingPolicyExpDate;
        IWebElement insuranceDetailsILD1;
        IWebElement insuranceDetailsILD2;
        IWebElement insuranceDetailsILD3;
        IWebElement insuranceDetailSectionBTN;
        IWebElement carValue;
        IWebElement carDetailsILD1;
        IWebElement carDetailsILD2;
        IWebElement carDetailsContinueBtn;
        IWebElement confirmDetailsPageCheckBox;
        IWebElement payInFull;

        public void DateLicenceWasIssued(string dd, string mm, string yy)
        {
            day = GetElementById("CompleteLicenceDetails_LicenceIssueDateDay");
            SelectByVisibleText(day, dd);
            month = GetElementById("CompleteLicenceDetails_LicenceIssueDateMonth");
            SelectByVisibleText(month, mm);
            year = GetElementById("CompleteLicenceDetails_LicenceIssueDateYear");
            SelectByVisibleText(year, yy);
        }

        public void ClickNoToPenaltyPoint()
        {
            ScrollToElement(day);
            penaltyPoint = GetElementByCssSelector("[for=\"CompleteLicenceDetails_HasPenaltyPointsB\"]");
            WaitForElementToBeClickable(penaltyPoint);
            penaltyPoint.Click();
        }

        public void ClickNoToLicenceDetailsILD()
        {
            ScrollToElement(year);
            licenceDetILD1 = GetElementByCssSelector("[for=\"CompleteLicenceDetails_Ild1B\"]");
            licenceDetILD1.Click();
            licenceDetILD2 = GetElementByCssSelector("[for=\"CompleteLicenceDetails_Ild2B\"]");
            licenceDetILD2.Click();
        }

        public void LicenceDetailSectionContinueBtn()
        {
            ldContinueBtn = GetElementByCssSelector("#completeLicenceDetails > ol > li.Bn > div > div:nth-child(1) > button");
            ldContinueBtn.Click();
        }

        public void EnterExistingPolicyExpiryDate(string expDate)
        {
            existingPolicyExpDate = GetElementById("CompleteInsuranceDetails_CurrentInsuranceExpiryDate");
            TypeGivenValueInto(existingPolicyExpDate, expDate);
        }

        public void InsuranceDetailsSectionILD()
        {
            ScrollToElement(existingPolicyExpDate);
            insuranceDetailsILD1 = GetElementByCssSelector("[for=\"CompleteInsuranceDetails_Ild8A\"]");
            insuranceDetailsILD1.Click();
            insuranceDetailsILD2 = GetElementByCssSelector("[for=\"CompleteInsuranceDetails_Ild4B\"]");
            insuranceDetailsILD2.Click();
            ScrollToElement(insuranceDetailsILD2);
            insuranceDetailsILD3 = GetElementByCssSelector("[for=\"CompleteInsuranceDetails_Ild5B\"]");
            insuranceDetailsILD3.Click();
        }
        public void ClickInsuranceDetailsContinueBtn()
        {
            insuranceDetailSectionBTN = GetElementByCssSelector("#completeInsuranceDetails > ol > li.Bn > div > div:nth-child(1) > button");
            insuranceDetailSectionBTN.Click();
        }

        public void ValueOfCar(string value)
        {
            WaitForElementToBeDisplayed("#CompleteCarDetails_CarValueId");
            carValue = GetElementById("CompleteCarDetails_CarValueId");
            SelectByVisibleText(carValue, value);
        }

        public void EnterCarPurchaseDate(string dd, string mm, string yy)
        {
            //day = GetElementById("CompleteCarDetails_CarPurchaseDateDay");
            //SelectByVisibleText(day, dd);
            month = GetElementById("CompleteCarDetails_CarPurchaseDateMonth");
            SelectByVisibleText(month, mm);
            year = GetElementById("CompleteCarDetails_CarPurchaseDateYear");
            SelectByVisibleText(year, yy);
        }
        public void CarDetailsILD()
        {
            //click yes on the slider for the car going on cover
            carDetailsILD1 = GetElementByCssSelector("[for=\"CompleteCarDetails_Ild6A\"]");
            carDetailsILD1.Click();
            ScrollToElement(carDetailsILD1);
            carDetailsILD2 = GetElementByCssSelector("[for=\"CompleteCarDetails_Ild7B\"]");
            carDetailsILD2.Click();
        }
        public void ClickCarDetailsSectionContinueBtn()
        {
            carDetailsContinueBtn = GetElementById("btnCompleteCarDetails");
            carDetailsContinueBtn.Click();
        }

        public void ConfirmDetailsSectionILDCheckBox()
        {
            //Thread.Sleep(1000);
            WaitForElementExistence("[class=\"wrapper clearfloat\"]");
            WaitForElementToBeDisplayed("#confirmSuppliedDetails > div.box.no-top-margin > div.content > div > ul > li.no-bullet > p > a:nth-child(2)");
            ScrollToElement(GetElementByCssSelector("#confirmSuppliedDetails > div.box.no-top-margin > div.content > div > ul > li.no-bullet > p > a:nth-child(2)"));
            WaitForElementToBeDisplayed("#confirmAll-input-wrapper > label");
            confirmDetailsPageCheckBox = GetElementByCssSelector("[for=\"confirmAll\"]");
            WaitForElementToBeClickable(confirmDetailsPageCheckBox);
            confirmDetailsPageCheckBox.Click();
        }

        public RealexpaymentsPage ClickPayInFullBtn()
        {    
            ScrollToTheButtomOfAPage();
            WaitForElementToBeDisplayed("#btnPayInFull");
            payInFull = GetElementById("btnPayInFull");
            payInFull.Click();
            return new RealexpaymentsPage();
        }

    }
}
