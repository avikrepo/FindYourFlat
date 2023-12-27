using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestProject2.Pages
{
    public class GenericMethods : BaseClass
    {

        public static IWebElement WaitForVisibilityOfElement(By locator)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            return wait.Until(ExpectedConditions.ElementIsVisible(locator));
        }

        public static void HardWait(int time)
        {
            Thread.Sleep(time);
        }

    }
}
