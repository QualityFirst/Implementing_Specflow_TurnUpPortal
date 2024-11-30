using OpenQA.Selenium;

namespace Implementing_Specflow_TurnUpPortal.Pages
{
    public class Login
    {
        public void LoginActions(IWebDriver driver)
        {
            // Launch TurnUp Portal
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/");

            //Maximize the browser window
            driver.Manage().Window.Maximize();
            Thread.Sleep(1000);

            // Identify username text box and enter valid user name
            IWebElement userNameTextBox = driver.FindElement(By.Id("UserName"));
            userNameTextBox.SendKeys("hari");

            // Identify password textbox and enter valid password
            IWebElement passwordTextBox = driver.FindElement(By.Id("Password"));
            passwordTextBox.SendKeys("123123");

            // Identify login button and click on it
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
            loginButton.Click();
            Thread.Sleep(1000);
        }

    }
}
