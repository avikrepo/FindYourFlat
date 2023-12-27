using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestProject2.Pages;

namespace TestProject2
{
    [TestClass]
    public class UnitTest1:BaseClass
    {
        [TestMethod]
        public void TestMethod1()
        {
            //IWebElement searchField = driver.FindElement(By.Id("keyword2"));
            //searchField.Click();
            PageObjects.homePage.SearchForByFlatInMultipleLocation();
        }
    }
}
