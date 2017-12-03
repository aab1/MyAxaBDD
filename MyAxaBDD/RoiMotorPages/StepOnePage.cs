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
        public void isMotorDSDisplayed()
        {
            yourDetailsSection = GetElementByCssSelector("#personal-details > legend");
            VerifyAnElementIsDisplayed(yourDetailsSection);
        }
        public void SelectTitle(string stitle)
        {
           title = GetElementById("YourDetails_TitleId");
            SelectByVisibleText(title, stitle);
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
    }
}
