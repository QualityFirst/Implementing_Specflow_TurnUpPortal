using OpenQA.Selenium;

namespace Implementing_Specflow_TurnUpPortal.Pages
{
    public class Home
    {
        public void NavigateToTMPage(IWebDriver driver)
        {
            // Click on Administration Menu
            IWebElement administrationTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a/span"));
            administrationTab.Click();

            // Click on Time and Materials Sub-Menu
            IWebElement timeAndMaterialOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            timeAndMaterialOption.Click();
        }

        public void NavigateToCustomersPage(IWebDriver driver)
        {
            // Click on Administration Menu
            IWebElement adminTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a/span"));
            adminTab.Click();

            // Click on Customers Sub-Menu
            IWebElement customersOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[1]/a"));
            customersOption.Click();
        }

    }
}
