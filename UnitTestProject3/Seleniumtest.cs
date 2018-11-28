using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;

class  SeleniumBingTests
{
    static void main()
    {
        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl("bloodpressure");
        IWebElement element = driver.FindElement(By.ClassName("control-lable"));
        if (element.Displayed)
        {
            System.Console.Write("element found");
            }
        driver.Quit();
    }
 }