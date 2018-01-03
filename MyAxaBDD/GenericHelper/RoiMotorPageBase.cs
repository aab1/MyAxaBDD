using MyAxaBDD.RoiMotorPages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAxaBDD.GenericHelper
{
    public class RoiMotorPageBase :BaseClass
    {
        public static StepOnePage NavigateToROIMotorDS()
        {
            LaunchUrl("https://dsdev.testaxa.ie/MotorQuote/");

            return new StepOnePage();
        }
        public static RoiMotorQteRetrievalPage NavigateToRoiMotorQuoteRetrievalPage()
        {
            //driver.FindElement(By.CssSelector("body")).SendKeys(Keys.Control + "t");
            //string newTabInstance = driver.WindowHandles[driver.WindowHandles.Count - 1].ToString();
            //driver.SwitchTo().Window(newTabInstance);
            //driver.Navigate().GoToUrl(url);
            //SwitchToWindow(1);
            LaunchUrl("https://dsdev.testaxa.ie/MotorQuote/RetrieveQuote/");
           
            return new RoiMotorQteRetrievalPage();
        }
    }
}
