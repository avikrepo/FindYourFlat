using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject2.Pages
{
    public class HomePage : BaseClass
    {
        public static By _searchField = By.Id("keyword2");
        public static By _firstSuggestion = By.XPath("(//div[@class='component__suggestor']/ul/li)[1]");
        public static By _search = By.XPath("//span[contains(text(),'Search')]");
        public static By _toggleVerifiedProperties = By.XPath("//div[@id='verified']/span/label/span[@class='toggle__switchButton']");
        public static By _maxBudgetDropdown = By.XPath("(//div[@id='bdf__lf_budMax']/div)[1]");

        public static IWebElement searchField { get { return driver.FindElement(_searchField); } }
        public static IWebElement firstSuggestion { get { return driver.FindElement(_firstSuggestion); } }
        public static IWebElement search { get { return driver.FindElement(_search); } }
        public static IWebElement toggleVerifiedProperties { get { return driver.FindElement(_toggleVerifiedProperties); } }
        public static IWebElement maxBudgetDropdown { get { return driver.FindElement(_maxBudgetDropdown); } }

        public void SearchForByFlatInMultipleLocation()
        {
            //GenericMethods.HardWait(5000);
            try
            {
                GenericMethods.WaitForVisibilityOfElement(_searchField);
                Click(searchField);
                string[] areas = { "Electronic City Phase 1", "HSR", "BTM", "Kudlu gate", "Haralur" };
                int count = 0;
                do
                {
                    searchField.SendKeys(areas[count]);
                    GenericMethods.WaitForVisibilityOfElement(_firstSuggestion);
                    Click(firstSuggestion);
                    count++;
                    GenericMethods.HardWait(1000);
                } while (count < areas.Length);
                GenericMethods.HardWait(5000);
                Click(search);


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
