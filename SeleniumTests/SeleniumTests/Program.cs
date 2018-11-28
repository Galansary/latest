using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace RunnigChrome
{
    class Program
    {
        static void Main(string[] args)
        {

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://webapptest-bpcalc.azurewebsites.net");
            driver.Navigate().Refresh();
            
        }
       
    }
}