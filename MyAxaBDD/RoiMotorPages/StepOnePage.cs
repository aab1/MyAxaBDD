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
    public class StepOnePage : RoiMotorPageBase
    {
        IWebElement yourDetailsSection;
        IWebElement title;
        IWebElement firstname;
        IWebElement lastname;
        IWebElement birthDay;
        IWebElement birthMonth;
        IWebElement birthYear;
        IWebElement gender;
        IWebElement email;
        IWebElement areaCode;
        IWebElement phoneNumb;
        string choosenTitle;
        IWebElement yesIknowYourEircode;
        IWebElement eircode;
        IWebElement confirmAddress;
        IWebElement addressCheckBox;
        IWebElement householdType;
        IWebElement employmentStatus;
        IList<IWebElement> occupation;
        IWebElement continueButton;
        IWebElement carReg;
        IWebElement confirmCar;
        IWebElement isThisTheCorrectCar;
        IWebElement willThisCarBeUsedForBusinessPurpose;
        IWebElement willThisCarBeUsedForCommutingToWork;
        IWebElement milleagePerYear;
        IWebElement continueBtnOnYourCarSection;
        IWebElement currentDrivingLicence;
        IWebElement drivingLicenceAge;
        IWebElement recentInsurance;
        IWebElement numOfClaimFreeYears;
        IWebElement drivingHistorySectionContinueBtn;
        IWebElement additionaldriverslider;
        IWebElement additonalDriverContinueBtn;
        IWebElement haveYouHadAnyClaims;
        IWebElement claimBtn;
        IWebElement anotherPolicy;
        IWebElement PayInFull;
        IWebElement assumptionCheckBox;
        IWebElement getQteBtn;
        IWebElement penaltyPoint;
        private static string proposersEmail;
        private static string bDay;
        private static string bMth;
        private static string bYr;
        public void isMotorDSDisplayed()
        {
            yourDetailsSection = GetElementByCssSelector("#personal-details > legend");
            VerifyAnElementIsDisplayed(yourDetailsSection);
        }
        public void SelectTitle(string stitle)
        {
           title = GetElementById("YourDetails_TitleId");
            SelectByVisibleText(title, stitle);
            choosenTitle =  stitle;
        }
        public void EnterFirstName(string fname)
        {
            firstname = GetElementById("YourDetails_FirstName");
            TypeGivenValueInto(firstname, fname);
        }

        public void EnterLastName(string lname) 
        {
            lastname = GetElementById("YourDetails_LastName");
            TypeGivenValueInto(lastname, lname);
        }

        public void SelectBirthDay(string bday)
        {
            birthDay = GetElementById("YourDetails_DateOfBirthDay");
            SelectByVisibleText(birthDay, bday);
            bDay = bday;
        }
        public void SelectBirthMonth(string bMonth)
        {
            birthMonth = GetElementById("YourDetails_DateOfBirthMonth");
            SelectByVisibleText(birthMonth, bMonth);
            bMth = bMonth;
        }

        public void SelectBirthYear(string bYear)
        {
            birthYear = GetElementById("YourDetails_DateOfBirthYear");
            SelectByVisibleText(birthYear, bYear);
            bYr = bYear;
        }
        public static string GetDayFromBirthDate()
        {
            return bDay;
        }
        public static string GetMonthFromBirthDate()
        {
            return bMth;
        }
        public static string GetYearFromBirthDate()
        {
            return bYr;
        }
        public void ClickGender(string selectGender)
        {
            if (choosenTitle.Equals("Dr"))
            {
                selectGender = selectGender.ToLower();
                if (selectGender.Equals("male"))
                {
                    ScrollToElement(GetElementById("YourDetails_DateOfBirthYear"));
                    gender = GetElementByCssSelector("[for=\"YourDetails_GenderIdA\"]");
                    WaitForElementToBeClickable(gender);
                    gender.Click();
                }
                else
                {
                    ScrollToElement(GetElementById("YourDetails_DateOfBirthYear"));
                    gender = GetElementByCssSelector("[for=\"YourDetails_GenderIdB\"]");
                    WaitForElementToBeClickable(gender);
                    gender.Click();
                }
            }else
            {
                //do nothing cos gender field will not be displayed
            }
        }
        public void EnterEmail(string proposerEmail)
        {
            email = GetElementById("YourDetails_EmailAddress");
            TypeGivenValueInto(email, proposerEmail);
            proposersEmail = proposerEmail;
        }
        public static  string GetEmail()
        {
            return proposersEmail;
        }
        public void SelectAreaCode(string userAreaCode)
        {
            areaCode = GetElementById("YourDetails_PhoneNumberAreaCode");
            SelectByVisibleText(areaCode, userAreaCode);
        }
        public void EnterPhoneNumber(string phoneNumber)
        {
            phoneNumb = GetElementById("YourDetails_PhoneNumberDigits");
            TypeGivenValueInto(phoneNumb, phoneNumber);
        }

        public void EnterEircode(string usersEircode)
        {
            yesIknowYourEircode = GetElementByCssSelector("[for=\"YourDetails_Address_UseEircodeA\"]");
            yesIknowYourEircode.Click();
            eircode = GetElementById("YourDetails_Address_EirCode");
            VerifyAnElementIsDisplayed(eircode);
            TypeGivenValueInto(eircode, usersEircode);
        }
        public void ClickConfirmAddress()
        {
            ScrollToElement(phoneNumb);
            confirmAddress = GetElementByCssSelector(".confirm-address-button-container [type]");
            WaitForElementToBeClickable(confirmAddress);
            confirmAddress.Click();
        }

        public void AddressCheckBox()
        {
            WaitForElementToBeDisplayed("[for=\"confirmAddress\"]");
            WaitForElementToDisAppear("class=\"validation-wrapper\"");
            addressCheckBox = GetElementById("confirmAddress-label");
            WaitForElementToBeClickable(addressCheckBox);
            addressCheckBox.Click();
        }
        public void SelectHouseHoldType(string houseHold)
        {
            householdType = GetElementById("YourDetails_HouseholdTypeId");
            SelectByVisibleText(householdType, houseHold);
        }

        public void SelectEmploymentStatus(string usersEmploymentStatus)
        {
            employmentStatus = GetElementById("YourDetails_EmploymentStatusId");
            SelectByVisibleText(employmentStatus, usersEmploymentStatus);
        }

        public void SelectOccupation(string usersOccupation)
        {
            string dynamicElement = ("[class=\"filterText novalidate evt-input-change-bound\"]");
            WaitForElementToBeDisplayed(dynamicElement);
            
            occupation = GetElementsByCssSelector(dynamicElement);
            TypeGivenValueInto(occupation.ElementAt(1), usersOccupation);

            //after typing into the field, get the webElement of the occupation you want to choose 
            IWebElement selectElementFromList = GetElementByCssSelector("body > ul:nth-child(1) > li:nth-child(1)");
            selectElementFromList.Click();
        }

        public void ClickContinueBtnOnDetailsSection() 
        {
            continueButton = GetElementById("btn-personal");
            continueButton.Click();
        }

        public void EnterCarReg(string enterCarReg)
        {
            WaitForElementToBeDisplayed("#VehicleDetails_RegistrationNumber");
            carReg = GetElementByCssSelector("#VehicleDetails_RegistrationNumber");
            TypeGivenValueInto(carReg, enterCarReg);
        }
        public void clickConfirmCarButton() 
        {
            confirmCar = GetElementById("confirmCarButton");
            WaitForElementToBeClickable(confirmCar); 
            confirmCar.Click();
        }

        public void IsThisTheCorrectCarClickYes()
        {
            isThisTheCorrectCar = GetElementByCssSelector("[for=\"IsVehicleRegConfirmedA\"]");
            WaitForElementToBeClickable(isThisTheCorrectCar);
            isThisTheCorrectCar.Click();
        }

        public void WillThisCarBeUsedForBusinessPurpose_ClickNO()
        {
            willThisCarBeUsedForBusinessPurpose = GetElementByCssSelector("[for=\"YourCar_BusinessUseB\"]");
            willThisCarBeUsedForBusinessPurpose.Click();
        }
        public void WillThisCarBeUsedForCommutingToWork_ClickNo()
        {
            willThisCarBeUsedForCommutingToWork = GetElementByCssSelector("[for=\"YourCar_CommutingUseTypeIdB\"]");
            willThisCarBeUsedForCommutingToWork.Click();
        }
        public void MilleagePerYear(string milleageInKm)
        {
            milleagePerYear = GetElementById("YourCar_DrivingUsageId");
            SelectByVisibleText(milleagePerYear, milleageInKm);
        }
        public void ClickContinueBtnOnYourCarSection()
        {
            continueBtnOnYourCarSection = GetElementById("btn-vehicle");
            ScrollToElement(milleagePerYear);
            continueBtnOnYourCarSection.Click();
        }

        public void SelectCurrentDrivingLicence(string drivingLicence)
        {
            currentDrivingLicence = GetElementById("YourDrivingHistory_DrivingLicenceTypeId");
            SelectByVisibleText(currentDrivingLicence, drivingLicence);
        }
        public void SelectNoToPenaltypoint()
        {
            penaltyPoint = GetElementByCssSelector("[for=\"YourDrivingHistory_HasPenaltyPointsB\"]");
            WaitForElementToBeClickable(penaltyPoint);
            penaltyPoint.Click();
        }
        public void SelectDrivingLicenceAge(string enterDrivingLicenceAge)
        {
            drivingLicenceAge = GetElementById("YourDrivingHistory_YearsDrivingLicenseHeldId");
            SelectByVisibleText(drivingLicenceAge, enterDrivingLicenceAge);
        }

        public void SelectRecentInsurance(string enterRecentInsurance)
        {
            WaitForElementToBeDisplayed("#YourDrivingHistory_DrivingExperienceId");
            recentInsurance = GetElementById("YourDrivingHistory_DrivingExperienceId");
            SelectByVisibleText(recentInsurance, enterRecentInsurance);
        }

        public void SelectNumOfClaimFreeYears(string enterNumOfClaimFreeYears)
        {
            numOfClaimFreeYears = GetElementById("YourDrivingHistory_NoClaimsDiscountYearsInOwnNameId");
            SelectByVisibleText(numOfClaimFreeYears, enterNumOfClaimFreeYears);
        }
        public void ClickDrivingHistorySectionContinueBtn()
        {
            drivingHistorySectionContinueBtn = GetElementById("btn-history");
            ScrollToElement(numOfClaimFreeYears);
            drivingHistorySectionContinueBtn.Click();
        }
        public void AdditionalDriver_ClickNO()
        {
            Thread.Sleep(500);
            //WaitForElementToBeDisplayed("[for=\"YourAdditionalDrivers_AddingAdditionalDriverB\"]");
            //WaitForElementExistence("class=\"validation-wrapper");
           
            additionaldriverslider = GetElementByCssSelector("[for=\"YourAdditionalDrivers_AddingAdditionalDriverB\"]");
            WaitForElementToBeClickable(additionaldriverslider);
            additionaldriverslider.Click();
        }

        public void AdditonalDriverContinueBtn()
        {
            additonalDriverContinueBtn = GetElementById("btn-additional-drivers");
            WaitForElementToBeClickable(additonalDriverContinueBtn);
            additonalDriverContinueBtn.Click();
        }

        public void HaveYouHadAnyClaims_ClickNo()
        {
            Thread.Sleep(500);
            haveYouHadAnyClaims = GetElementByCssSelector("[for=\"YourClaims_AddingClaimB\"]");
            haveYouHadAnyClaims.Click();
        }

        public void ClickBtnClaims()
        {
            claimBtn = GetElementById("btn-claims");
            ScrollToElement(haveYouHadAnyClaims);
            WaitForElementToBeClickable(claimBtn);
            claimBtn.Click();
        }
        public void ClickNoButtonWhenAskedHaveAnotherPolicyInsuredWithAAXA()
        {
            WaitForElementToBeDisplayed("[for=\"YourCover_MultiProductB\"]");
            anotherPolicy = GetElementByCssSelector("[for=\"YourCover_MultiProductB\"]");
            WaitForElementToBeClickable(anotherPolicy);
            anotherPolicy.Click();
        }

        public void PayInFullBtn()
        {
            PayInFull = GetElementByCssSelector("[for=\"YourCover_HowDoYouNormallyPayIdA\"]");
            PayInFull.Click();
        }

        public void TickAgreeTermsCheckBox()
        {
            assumptionCheckBox = GetElementById("agree-terms-label");
            assumptionCheckBox.Click();
        }

        public StepTwoPage ClickGetQuoteBtn()
        {
            ScrollToTheButtomOfAPage();
            getQteBtn = GetElementById("btn-getQuote");
            getQteBtn.Click();
            return new StepTwoPage();
        }
        public StepTwoPage VerifythatStepTwoUrlIsDisplayed()
        {
            WaitUntilUrlContainsASpecifiedWord("Step2");
            string pageTitle = driver.Title;
            driver.Url.Contains("MotorQuote/Step2");
            return new StepTwoPage();
        }
    }
}
