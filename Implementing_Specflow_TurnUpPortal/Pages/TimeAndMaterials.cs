using Implementing_Specflow_TurnUpPortal.Utilities;
using Implementing_Specflow_TurnUpPortal.XPaths;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace Implementing_Specflow_TurnUpPortal.Pages
{
    public class TimeAndMaterials
    {
        public void CreateTimeRecord(IWebDriver driver)
        {
            // WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));

            // Click on Create New Button
            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createNewButton.Click();

            // Click on the drop down triangle icon to see Type Code drop down values
            IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
            typeCodeDropdown.Click();

            Wait.WaitToBeVisible(driver, "XPATH", TM_XPaths.typeCode, 5);
            // Applying Selenium Wait
            IWebElement timeOption = driver.FindElement(By.XPath(TM_XPaths.typeCode));
            // Choose Time as an option for the Type Code
            timeOption.Click();

            // Write Code in the Code text box
            IWebElement codeTextBox = driver.FindElement(By.Id("Code"));
            codeTextBox.SendKeys("N-1");

            // Write description in the text box
            IWebElement descriptionTextBox = driver.FindElement(By.Id("Description"));
            descriptionTextBox.SendKeys("N-1-Description");

            // Click the text box to allow entering price in it as the element with id price was not interactable as per selenium exception thrown 
            IWebElement priceTagOverlap = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            priceTagOverlap.Click();

            // Write value for Price in the text box
            IWebElement pricePerUnit = driver.FindElement(By.Id("Price"));
            pricePerUnit.SendKeys("20");

            Thread.Sleep(3000);

            // Click on Save button
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();

            Wait.WaitToBeVisible(driver, "XPATH", TM_XPaths.lastPage, 2);
            // Go to the last page of the grid and wait until the element is visible
            IWebElement goToLastPage = driver.FindElement(By.XPath(TM_XPaths.lastPage));
            goToLastPage.Click();
        }

        public string GetCode(IWebDriver driver)
        {
            IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            return newCode.Text;
        }

        public string GetDescription(IWebDriver driver)
        {
            IWebElement newDescription = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[3]"));
            return newDescription.Text;
        }

        public string GetPrice(IWebDriver driver)
        {
            IWebElement newPrice = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[4]"));
            return newPrice.Text;
        }

        public string GetEditedCode(IWebDriver driver)
        {
            IWebElement editedCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            return editedCode.Text;
        }

        public string GetEditedDescription(IWebDriver driver)
        {
            IWebElement editedDescription = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[3]"));
            return editedDescription.Text;
        }

        public void EditTimeRecord(IWebDriver driver, string code, string description)
        {
            Thread.Sleep(2000);
            // WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            Wait.WaitToBeVisible(driver, "XPATH", TM_XPaths.lastPage, 3);
            // Go to the last page of the grid and wait until element is loaded
            IWebElement navigateToLastPage = driver.FindElement(By.XPath(TM_XPaths.lastPage));
            navigateToLastPage.Click();

            // IWebElement navigateToLastRecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            // Edit new record
            IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            editButton.Click();

            // Select the triangle icon of the Type code drop down 
            IWebElement typeCodeDropDown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
            typeCodeDropDown.Click();

            // Applying Selenium Wait
            Wait.WaitToBeVisible(driver, "XPATH", TM_XPaths.materialDropDown, 3);
            IWebElement materialSelection = driver.FindElement(By.XPath(TM_XPaths.materialDropDown));

            // Change the value of the drop down to Material
            materialSelection.Click();

            // Edit the Code
            IWebElement editCodeTextBox = driver.FindElement(By.Id("Code"));
            editCodeTextBox.Clear();
            editCodeTextBox.SendKeys(code);

            // Edit description
            IWebElement editDescription = driver.FindElement(By.Id("Description"));
            editDescription.Clear();
            editDescription.SendKeys(description);

            // Click on Edit Price Text Box
            IWebElement clickPriceOverlap = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            clickPriceOverlap.Click();

            // Now Edit the price
            IWebElement editPrice = driver.FindElement(By.Id("Price"));
            editPrice.Clear();

            clickPriceOverlap.Click();

            // Now Edit the price
            IWebElement editPrice2 = driver.FindElement(By.Id("Price"));
            editPrice2.SendKeys("40");

            Thread.Sleep(3000);

            // Click on Save Button
            IWebElement clickSaveButton = driver.FindElement(By.Id("SaveButton"));
            clickSaveButton.Click();

            // Go to the last page of the grid and wait until element is loaded
            Wait.WaitToBeVisible(driver, "XPATH", TM_XPaths.lastPage, 2);
            IWebElement goToLastPage = driver.FindElement(By.XPath(TM_XPaths.lastPage));
            goToLastPage.Click();

            // IWebElement getLastRecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            //Assert.That(getLastRecord.Text == "Edited N-1", "Time record not updated successfully. Test Failed");
        }

        public void DeleteTimeRecord(IWebDriver driver)
        {
            Thread.Sleep(2000);
            //  WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));

            // Go to the last page of the grid and wait until element is loaded
            Wait.WaitToBeVisible(driver, "XPATH", TM_XPaths.lastPage, 3);
            IWebElement navigateToLastPage = driver.FindElement(By.XPath(TM_XPaths.lastPage));
            navigateToLastPage.Click();

            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            deleteButton.Click();

            // Applying Selenium Wait
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));

            IAlert alert = wait.Until(ExpectedConditions.AlertIsPresent());

            // Handle the alert (Click OK)
            alert.Accept();

            Thread.Sleep(1000);
            IWebElement moveToLastRecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            //Assert.That(moveToLastRecord.Text != "Edited N-1", "Time record is not deleted successfully. Test Failed");

            // Thread.Sleep(1000);
        }

    }
}
