

using NUnit.Framework;

namespace MyAxaBDD.UnitTests
{
    [TestFixture]
    public class TestScreenShots :BaseClass
    {
       [Test] 
       public void TestScreenshotMethod()
        {
            LaunchBrowser("Chrome");
            LaunchUrl("http://www.foxnews.com/us.html");
            SaveScreenshot();
            CloseBrowser();
        }
    }
}
