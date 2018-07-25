using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace CSSSR
{
    [TestFixture]
    public class UnitTest1
    {
        public IWebDriver driver;

        [SetUp] 
        public void SetUp()
        {
            ChromeOptions co = new ChromeOptions();
            driver = new ChromeDriver(co);
        }

        [TearDown] 
        public void TearDown()
        {
            driver.Quit();
        }

        [Test]
        public void Check()
        {
            string actual = "http://monosnap.com/";
            CheckAddres check = new CheckAddres(driver);
            check.Action();

            Assert.AreEqual(check.H, actual);
        }
    }
}
