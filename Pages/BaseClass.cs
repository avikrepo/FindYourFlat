using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject2.Pages
{
    public class BaseClass
    {
        public static IWebDriver driver { get; set; }

        [TestInitialize]
        public void BeforeTest()
        {
            if(driver == null)
            {
                InitializeBrowser();
                driver.Manage().Cookies.DeleteAllCookies();
                driver.Manage().Window.Maximize();
                var options = new ChromeOptions();
                options.AddUserProfilePreference("safebrowsing.enabled", true);

            }
        }
        public static void InitializeBrowser()
        {
            driver = new ChromeDriver();         
            driver.Navigate().GoToUrl("https://www.99acres.com/");
        }

        [AssemblyCleanup]
        public static void ClearBrowser()
        {
            driver.Close();
            driver.Quit();
        }

        public static void Click(IWebElement element)
        {
            element.Click();
        }
    }
}
