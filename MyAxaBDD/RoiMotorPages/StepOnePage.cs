using MyAxaBDD.GenericHelper;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        }
        public void SelectBirthMonth(string bMonth)
        {
            birthMonth = GetElementById("YourDetails_DateOfBirthMonth");
            SelectByVisibleText(birthMonth, bMonth);
        }

        public void SelectBirthYear(string bYear)
        {
            birthYear = GetElementById("YourDetails_DateOfBirthYear");
            SelectByVisibleText(birthYear, bYear);
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
        public void EnterEmail(String proposerEmail)
        {
            email = GetElementById("YourDetails_EmailAddress");
            TypeGivenValueInto(email, proposerEmail);
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
            addressCheckBox = GetElementById("confirmAddress-label");
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
    }
}
