

using NUnit.Framework;

namespace MyAxaBDD.UnitTests
{
    [TestFixture]
    public class TestScreenShots :BaseClass
    {
       [Test,Ignore("This is just a unit test")] 
       public void TestScreenshotMethod()
        {
            LaunchBrowser("Chrome");
            LaunchUrl("http://www.foxnews.com/us.html");
            //SaveScreenshot();
            //CloseBrowser();
        }
    }
}
