using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;

namespace SeleniumBingTests
{
    /// <summary>
    /// Summary description for MySeleniumTests
    /// </summary>
    [TestClass]
    public class MySeleniumTests
    {
        private TestContext testContextInstance;
        private IWebDriver driver;
        private string appURL;


        public MySeleniumTests()
        {
        }

        [TestMethod]
        [TestCategory("Chrome")]
        public void TheChromeTest()
        {
            driver.Navigate().GoToUrl(appURL + "/");
            Assert.AreEqual(true ,driver.FindElement(By.XPath("/html/body/div/h4")).Displayed); // Visible Works headers BPcalculator
            Assert.AreEqual(true ,driver.FindElement(By.XPath("/html/body/nav/div/div[1]/a")).Displayed); // Visible Works headers in Black
        }
        [TestMethod]
        [TestCategory("fireFox")]
        public void theFireFoxTest()
        {
            driver.Navigate().GoToUrl(appURL + "/");
            Assert.AreEqual(true, driver.FindElement(By.XPath("/html/body/div/h4")).Displayed); // Visible Works headers BPcalculator
            Assert.AreEqual(true, driver.FindElement(By.XPath("/html/body/nav/div/div[1]/a")).Displayed); // Visible Works headers in Black
        }

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        [TestInitialize()]
        public void SetupTest()
        {
            appURL = "http://webapptest-bpcalc.azurewebsites.net/";

            string browser = "Chrome";
            switch (browser)
            {
                case "Chrome":
                    driver = new ChromeDriver(Environment.GetEnvironmentVariable("ChromeWebDriver"));
                    break;
                case "Firefox":
                    driver = new FirefoxDriver();
                    break;
                case "IE":
                    driver = new InternetExplorerDriver();
                    break;
                default:
                    driver = new ChromeDriver(Environment.GetEnvironmentVariable("ChromeWebDriver"));
                    break;
            }

        }

        [TestCleanup()]
        public void MyTestCleanup()
        {
            driver.Quit();
        }
    }
}