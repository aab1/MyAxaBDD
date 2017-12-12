﻿using MyAxaBDD.SpecflowHooks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.PhantomJS;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyAxaBDD
{
    public class BaseClass
    {

        public static IWebDriver driver;
        private static SelectElement select;

        static BaseClass()
        {
            driver = null;
            select = null;
        }
        public static void LaunchBrowser(string browser)
        {
            switch (browser)
            {
                case "Chrome":
                    driver = InitChrome();
                    break;
                case "Firefox":
                    driver = InitFirefox();
                    break;
                case "InternetExplorer":
                    driver = InitInternetExplorer();
                    break;

                case "PhantomJs":
                    driver = initPhantomJsDriver();
                    break;
                default:
                    Console.WriteLine(browser + " Is not recognised. So, Firefox is lauched instead");
                    driver = InitFirefox();
                    break;
            }
            //driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(140));
            //driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(2));
            driver.Manage().Window.Maximize();
        }
        private static PhantomJSDriver initPhantomJsDriver()
        {
            PhantomJSDriver driver = new PhantomJSDriver(GetPhantomJsDriverService());
            return driver;
        }
        private static PhantomJSOptions GetPhantomJsptions()
        {
            PhantomJSOptions option = new PhantomJSOptions();
            option.AddAdditionalCapability("handlesAlerts", true);
            return option;
        }
        private static PhantomJSDriverService GetPhantomJsDriverService()
        {
            PhantomJSDriverService service = PhantomJSDriverService.CreateDefaultService();
            service.LogFile = "TestPhantomJS.log";
            service.HideCommandPromptWindow = false;
            service.LoadImages = true;
            return service;
        }

        private static IWebDriver InitInternetExplorer()
        {
            driver = new InternetExplorerDriver();
            return driver;
        }

        private static IWebDriver InitChrome()
        {
            driver = new ChromeDriver();

            return driver;
        }

        private static IWebDriver InitFirefox()
        {
            driver = new FirefoxDriver();

            return driver;
        }
        //################################################################################################################
        public static void LaunchUrl(string url)
        {
            driver.Navigate().GoToUrl(url);
        }
        //################################################################################################################
        public static void MaximiseBrowser()
        {
            driver.Manage().Window.Maximize();
        }
        public static void CloseBrowser()
        {
            if (driver != null)
            {
                driver.Manage().Cookies.DeleteAllCookies();
                driver.Close();
                driver.Quit();
            }
        }
        /*
         * Add spaces to sentence
         * ##########################################################################################################
         */
       
        /*#################################################################################################
        Uses - This method helps to type given value into a field
        It takes in any WebElement of interest and the value to type in
        ###################################################################################################
        */
        public static void TypeGivenValueInto(IWebElement element, String text)
        {
            element.Clear();
            element.SendKeys(text);
        }

        /*########################################################################################################
         * Wait until url contains a specified word
         */
         public void WaitUntilUrlContainsASpecifiedWord(string word)
        {
            WebDriverWait w = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            w.IgnoreExceptionTypes(typeof(StaleElementReferenceException),typeof(InvalidElementStateException));
            w.Until(ExpectedConditions.UrlContains(word));
        }
        /*########################################################################################################
         * This methods waits 10 second for an element to be clickable
         * @param input any IWebElement
         */
        public void WaitForElementToBeClickable(IWebElement element)
        {
            WebDriverWait w = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            w.IgnoreExceptionTypes(typeof(StaleElementReferenceException), typeof(InvalidElementStateException));
            w.Until(ExpectedConditions.ElementToBeClickable(element));
        }
        /*
         * ########################################################################################################
         *  @param input the string value of the css selector from webElement
         */
        public void WaitForElementToBeDisplayed(string element)
        {
            WebDriverWait w = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            w.IgnoreExceptionTypes(typeof(StaleElementReferenceException), typeof(InvalidElementStateException));
            w.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(element)));
        }
        /*
         * ########################################################################################################
         * scroll to an element that is located by IWebElement
         */
        public static void ScrollToElement(IWebElement element)
        {
            IJavaScriptExecutor executor = (IJavaScriptExecutor) driver;
            //IWebElement elem = GetElementByCssSelector(element);
            executor.ExecuteScript("window.scrollTo(0," + element.Location.Y + ")");
        }

        /*########################################################################################################
         * This method helps to scroll to the bottom of a page*/
        public static void ScrollToTheButtomOfAPage() 
        {
		 ((IJavaScriptExecutor) driver)
         .ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");
        }
        /*########################################################################################################
	    Uses - This method helps to assert/validate that an element is displayed
	    It takes in any IWebElement of interest
	    ##########################################################################################################*/
        public static void VerifyAnElementIsDisplayed(IWebElement element) 
        {
            Assert.True(element.Displayed, element+" is not displayed");
        }

        /*##########################################################################################################
         *  All Combobox(i.e dropdown) helper starts here
        */
        public static void SelectByIndex(IWebElement element, int index)
        {
            select = new SelectElement(element);
            select.SelectByIndex(index);
        }
        public static void SelectByVisibleText(IWebElement element, string text)
        {
            select = new SelectElement(element);
            select.SelectByText(text);
        }
        public static void SelectByValue(IWebElement element, string value)
        {
            select = new SelectElement(element);
            select.SelectByValue(value);
        }

        //####################### Find WebElelement ################################################################
        public static IWebElement GetElementById(string id)
        {
            By locator = By.Id(id);
            return GetElement(locator);
        }
        public static IWebElement GetElementByClassName(string className)
        {
            By locator = By.ClassName(className);
            return GetElement(locator);
        }
        public static IWebElement GetElementByCssSelector(string cssSelector)
        {
            By locator = By.CssSelector(cssSelector);
            return GetElement(locator);
        }
        public static IWebElement GetElementByName(string name)
        {
            By locator = By.Name(name);
            return GetElement(locator);
        }
        public static IWebElement GetElementByXpath(string xpath)
        {
            By locator = By.XPath(xpath);
            return GetElement(locator);
        }
        public static IWebElement GetElementByTagName(string tagname)
        {
            By locator = By.TagName(tagname);
            return GetElement(locator);
        }
        public static IWebElement GetElementByLinkText(string linkText)
        {
            By locator = By.LinkText(linkText);
            return GetElement(locator);
        }
        public static IList<IWebElement> GetElementsById(string id)
        {
            By locator = By.Id(id);
            return GetElements(locator);
        }
        public static IList<IWebElement> GetElementsByClassName(string className)
        {
            By locator = By.ClassName(className);
            return GetElements(locator);
        }
        public static IList<IWebElement> GetElementsByCssSelector(string cssSelector)
        {
            By locator = By.CssSelector(cssSelector);
            return GetElements(locator);
        }
        public static IList<IWebElement> GetElementsByName(string name)
        {
            By locator = By.Name(name);
            return GetElements(locator);
        }
        public static IList<IWebElement> GetElementsByXpath(string xpath)
        {
            By locator = By.XPath(xpath);
            return GetElements(locator);
        }
        public static IList<IWebElement> GetElementsByTagName(string tagname)
        {
            By locator = By.TagName(tagname);
            return GetElements(locator);
        }
        private static IWebElement GetElement(By locator)
        {
            IWebElement element = null;
            int tryCount = 0;
            while (element == null)
            {
                try
                {
                    element = driver.FindElement(locator);
                    return new WebDriverWait(driver, TimeSpan.FromSeconds(2))
                       .Until(ExpectedConditions.ElementExists(locator));
                }
                catch (Exception e)
                {
                    if (tryCount == 3)
                    {
                        SaveScreenshot();
                          throw e;
                    }
                }
                //var waitTime = new TimeSpan(0, 0, 0);
                //Thread.Sleep(waitTime);
                tryCount++;
                

                
            }
            Console.WriteLine("{0} is now retrieved", element.ToString());
            return element;
        }

        private static IList<IWebElement> GetElements(By locator)
        {
            IList<IWebElement> element = null;
            int tryCount = 0;
            while (element == null)
            {
                try
                {
                    element = driver.FindElements(locator);
                    return new WebDriverWait(driver, TimeSpan.FromSeconds(2))
                       .Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(locator));
                }
                catch (Exception e)
                {
                    if (tryCount == 3)
                    {
                        SaveScreenshot();
                        throw e;
                    }
                }
                //var waitTime = new TimeSpan(0, 0, 2);
                //Thread.Sleep(waitTime);

                tryCount++;
            }
            Console.WriteLine("{0} is now retrieved", element.ToString());
            return element;
        }
        //####################################################################################################################
        private static Screenshot TakeScreenshot()
        {
            return ((ITakesScreenshot)driver).GetScreenshot();
        }
        public static string ScreenShotLocation()
        {
            var dateNow = DateTime.Now.Date.ToString().Replace(@"/", "").Replace(@":", "");
            dateNow = dateNow.Substring(0, 8);

            var timeNow = DateTime.Now.TimeOfDay.ToString().Replace(@"/", "").Replace(@" ", "").Replace(@":", "").Replace(@".", "");
            timeNow = timeNow.Substring(0, 6);

            //Change the location(i.e C:\\Screenshots) to any drive as required provided others need to see the screenshot e.g f drive
            return String.Format("C:\\Screenshots\\{0}_{1}.png", dateNow, timeNow);
        }
        public static void SaveScreenshot()
        {
            try
            {
                var location = ScreenShotLocation();
                var screenshot = TakeScreenshot();
                screenshot.SaveAsFile(location, ScreenshotImageFormat.Png);
                TestController.ExtentLogScreenshotLocation(location);
            }
            catch (Exception e)
            {
                Console.Write(String.Format("Screenshot cannot be saved because {0}", e));
            }
        }
        //#########################################################################################################################

    }
}
