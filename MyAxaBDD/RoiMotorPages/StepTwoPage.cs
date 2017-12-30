using MyAxaBDD.GenericHelper;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAxaBDD.RoiMotorPages
{
    public class StepTwoPage : RoiMotorPageBase
    {
        IWebElement buyNowBtn;
        IWebElement quotereference;

        public void VerifyThatStepTwoIsDisplayed()
        {
            buyNowBtn = GetElementByCssSelector("#premium-display-wrapper > button");
            VerifyAnElementIsDisplayed(buyNowBtn);
        }
        public StepThreePage ClickBuyNowBtn()
        {
            buyNowBtn.Click();
            return new StepThreePage();
        }
        public  StepThreePage VerifyThatStepThreeIsDisplayed()
        {
            WaitUntilUrlContainsASpecifiedWord("Step3");
            quotereference = GetElementById("quoteReference");
            VerifyAnElementIsDisplayed(quotereference);
            return new StepThreePage();
        }
    }
}
