using MyAxaBDD.GenericHelper;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyAxaBDD.RoiMotorPages
{
    public class StepTwoPage : RoiMotorPageBase
    {
        IWebElement quoteReference;
        IWebElement buyNowBtn;
        IWebElement saveQuoteBtn;
        IWebElement quotereference;
        IWebElement tpft;
        IWebElement glassBreakage;
        IWebElement injuryCover;
        IWebElement carHireBtn;
        IWebElement saveQuoteAlertBox;
        IWebElement legalExpenses;

       private static string refNum;

        public void VerifyThatStepTwoIsDisplayed()
        {
            quoteReference = GetElementById("qtpFullQuoteRef");
            WaitForElementToBeDisplayed("#qtpFullQuoteRef");
            VerifyAnElementIsDisplayed(quoteReference);
        }
        public void ClickSaveQuoteBtn()
        {
            refNum = GetElementById("qtpFullQuoteRef").Text;
            ScrollToElement(GetElementByCssSelector("#premium-display-wrapper > button"));
            saveQuoteBtn = GetElementByCssSelector("#next-steps-buttons > a.btn.btn-secondary.btn-icon.icon.saveQuote");
            WaitForElementToBeClickable(saveQuoteBtn);
            saveQuoteBtn.Click();
        }
        public static string GetQuoteReferenceNumber()
        {
            return refNum;
        }

        public void VerifyThatQuoteIsSavedSucessFully()
           {
            //driver.SwitchTo().Alert();
            WaitForElementToBeDisplayed("#save-quote-modal > div.box-header > h2");
            saveQuoteAlertBox = GetElementByCssSelector("#save-quote-modal > div.box-header > h2");
            saveQuoteAlertBox.Text.Equals("Your quote has been saved");
        }
        public StepThreePage ClickBuyNowBtn()
        {
            buyNowBtn = GetElementByCssSelector("#premium-display-wrapper > button");
            buyNowBtn.Click();
            return new StepThreePage();
        }
        public void ClickSwitchToTPFT()
        {
            tpft = GetElementByCssSelector("#premium-display-wrapper > div:nth-child(6) > a");
            WaitForElementToBeClickable(tpft);
            tpft.Click();
        }
        public void AddGlassBreakage()
        {
            WaitForElementToBeDisplayed("#premium-display-wrapper > button");
            Actions act = new Actions(driver);
            ScrollToElement(GetElementByCssSelector("#PromotionCode_Btn"));
            WaitForElementExistence("#additional-cover-wrapper > div:nth-child(1) > div:nth-child(1) > div.content > div > div.toggle.add-remove-toggle > label > span.unchecked");
            glassBreakage = GetElementByCssSelector("#additional-cover-wrapper > div:nth-child(1) > div:nth-child(1) > div.content > div > div.toggle.add-remove-toggle > label > span.unchecked");
            WaitForElementToBeClickable(glassBreakage);
            act.MoveToElement(glassBreakage).Click().Build().Perform();
        }
        public void AddInjuryCover()
        {
            injuryCover = GetElementByCssSelector("#additional-cover-wrapper > div:nth-child(2) > div:nth-child(1) > div.content > div > div.toggle.add-remove-toggle > label > span.unchecked");
            injuryCover.Click();
        }
        public void AddCarAndKeyRescue()
        {
            ScrollToElement(injuryCover);
            GetElementByCssSelector("#additional-cover-wrapper > div:nth-child(1) > div:nth-child(4) > div.content > div > div.toggle.add-remove-toggle > label > span.unchecked").Click();
        }
        public void AddLegalExpenses()
        {
            legalExpenses = GetElementByCssSelector("#additional-cover-wrapper > div:nth-child(2) > div:nth-child(2) > div.content > div > div.toggle.add-remove-toggle > label > span.unchecked");
            legalExpenses.Click();
        }
        public void AddOpenDriving()
        {
            WaitForElementToDisAppear("class=\"wrapper clearfloat\"");
            ScrollToElement(GetElementByCssSelector("#additional-cover-wrapper > div:nth-child(1) > div:nth-child(5) > div.box-header > h2"));
            GetElementByCssSelector("#additional-cover-wrapper > div:nth-child(1) > div:nth-child(5) > div.content > div > div.toggle.add-remove-toggle > label").Click();
        }
        public void AddCarHireReplacementPlus()
        {
            carHireBtn = GetElementByCssSelector("#additional-cover-wrapper > div:nth-child(2) > div:nth-child(3) > div.content > div > div.toggle.add-remove-toggle > label > span.unchecked");
            carHireBtn.Click();
        }
        public void AddProtectedNCD()
        {
            //WaitForElementToBeDisplayed()
            ScrollToElement(GetElementByCssSelector("#additional-cover-wrapper > div:nth-child(1) > div:nth-child(6) > div.box-header > h2"));
            GetElementByCssSelector("#additional-cover-wrapper > div:nth-child(1) > div:nth-child(6) > div.content > div > div.toggle.add-remove-toggle > label > span.unchecked").Click();
        }
        public void ClickUpdateYourQuote()
        {
            ScrollToTheButtomOfAPage();
            ScrollToElement(GetElementByCssSelector("#policy-benefits-wrapper > div:nth-child(2) > div > div > a"));
            GetElementByCssSelector("#main-content-wrapper > section.band.color-d-bg.blur-on-updating.blur-on-update-required > div.update-required-message.darken-more > button").Click();
            
        }
        public StepThreePage ClickContinueToBuy()
        {
            Thread.Sleep(10000);
            ScrollToTheButtomOfAPage();
            WaitForElementToDisAppear("[class=\"color - d - bg blur - on - update - required\"]");
            ClickUsingActionClass("#main-content-wrapper > section:nth-child(8) > div > div > div > div > a.btn.btn-go.btn-icon-right.icon.buy-now-btn");
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
