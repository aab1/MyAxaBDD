using MyAxaBDD.Reports;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using RelevantCodes.ExtentReports;
using System;
using System.IO;
using System.Text;

namespace MyAxaBDD.SpecflowHooks
{
    public static class TestController
    {
        private static ExtentReports _extent;
        private static ExtentTest _test;

        public static void InitialiseReport()
        {
            string path = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            string actualPath = path.Substring(0, path.LastIndexOf("bin"));
            string projectPath = new Uri(actualPath).LocalPath;

            _extent = ExtentManager.Instance;
            
            string testname = TestContext.CurrentContext.Test.Name.ToString();
            testname = RemoveStringFromAGivenCharacter(testname, "(");

            // substring of test Name
            //int index = testname.IndexOf("(");
            //if (index > 0)
            //    testname = testname.Substring(0, index);

            testname = AddSpacesToSentence(testname);
            // _test = _extent.StartTest(TestContext.CurrentContext.Test.Name);
            _test = _extent.StartTest(testname);
            _test.Log(LogStatus.Info, String.Format("{0} is up and running", testname));

            _extent
            .AddSystemInfo("Host Name", "Yemi")
            .AddSystemInfo("Environment", "QA")
            .AddSystemInfo("User Name", "Yemi Bakare");
            _extent.LoadConfig(projectPath + "extent-config.xml");
        }
        /*#####################################################################################################
         * This Method that adds space to the long word that is joined
         * together by capital letter ThisIsAnExample 
         */
        public static string AddSpacesToSentence(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return "";
            StringBuilder newText = new StringBuilder(text.Length * 2);
            newText.Append(text[0]);
            for (int i = 1; i < text.Length; i++)
            {
                if (char.IsUpper(text[i]) && text[i - 1] != ' ')
                    newText.Append(' ');
                newText.Append(text[i]);
            }
            return newText.ToString();
        }
        /*########################################################################################################
         * 
         */
        public static string RemoveStringFromAGivenCharacter(string actualText, string deleteFromThischaracter)
        {
            int index = actualText.IndexOf(deleteFromThischaracter);
            if (index > 0)
                actualText = actualText.Substring(0, index);
            return actualText;

        }

        //########################################################################################################
        public static void ExtentTearDown()
        {
            try
            {
                ExtentReportCaptureTearDown();

            }
            catch (IOException ioException)
            {
                //Helper.MsgOutput("Report could not be written to specified location", ioException.ToString());
            }
        }

        public static void ExtentLogScreenshotLocation(string path)
        {
            _test.Log(LogStatus.Info, "The screenshot of the failed page is attached below: " + _test.AddScreenCapture(path));
        }

        public static void ExtentLogPassInformation(string step)
        {
            var text = String.Format("{0} step has been successfully completed", step);
            _test.Log(LogStatus.Pass, text);
        }
        public static void ExtentLogFailInformation(string step, string message)
        {
            var text = String.Format("{0} failed because of the following error message {1}", step, message);
            _test.Log(LogStatus.Fail, text);
        }

        public static void ExtentLogFatalInformation()
        {
            const string text = "Unable to create a new Remote WebDriver instance";
            _test.Log(LogStatus.Fatal, text);
        }

        public static void ExtentLogInformation(string value, string enteredOrRetrieved)
        {
            var text = String.Format("{0} has been successfully {1}", value, enteredOrRetrieved);
            _test.Log(LogStatus.Info, text);
        }

        public static void ExtentLogFeatureInformation(string value)
        {
            var text = String.Format("{0} has finished running", value);
            _test.Log(LogStatus.Info, text);
        }

        public static void ExtentLogInformation()
        {
            const string text = "Step successfully completed";
            _test.Log(LogStatus.Info, text);
        }

        public static void ExtentIgnoreInformation(string message)
        {
            _test.Log(LogStatus.Info, message);
        }

        public static void ExtentReportCaptureTearDown()
        {
            var status = TestContext.CurrentContext.Result.Outcome;

            LogStatus logstatus;

            switch (status.Status)
            {
                case TestStatus.Failed:
                    logstatus = LogStatus.Fail;
                    break;
                case TestStatus.Inconclusive:
                    logstatus = LogStatus.Warning;
                    break;
                case TestStatus.Skipped:
                    logstatus = LogStatus.Skip;
                    break;
                default:
                    logstatus = LogStatus.Pass;
                    break;
            }

            _test.Log(logstatus, "Test ended with " + logstatus);

            _extent.EndTest(_test);
            _extent.Flush();
        }
    }
}

