using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WebDriverExtensions
{
    public static class WebElementExtensions
    {
        public static bool ElementIsPresent(this IWebDriver driver, By by)
        {
            try
            {
                return driver.FindElement(by).Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }

    [TestClass]
    public class ExtensionUnitTests
    {
        [TestMethod]
        public void FindVisibleElements()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://webapptest-bpcalc.azurewebsites.net/");
            Assert.AreEqual(true, driver.ElementIsPresent(By.XPath("/html/body/div/h4"))); // Visible Works
            Assert.AreEqual(true, driver.ElementIsPresent(By.XPath("/html/body/nav/div/div[1]/a"))); // Visible Works
          
            driver.Quit();
        }
    }
}