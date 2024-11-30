using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace Implementing_Specflow_TurnUpPortal.Pages
{
    public class Customers
    {
        public void CreateCustomersRecord(IWebDriver driver)
        {
            IWebElement createNewCustomerButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createNewCustomerButton.Click();

            IWebElement nameTextBox = driver.FindElement(By.Id("Name"));
            nameTextBox.SendKeys("NCustomer");

            IWebElement editContactButton = driver.FindElement(By.Id("EditContactButton"));
            editContactButton.Click();

            //Thread.Sleep(2000);
            //*[@id="ContactEditForm"]
            // Applying Selenium Wait
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            IWebElement editForm = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"contactDetailWindow\"]/iframe")));
            driver.SwitchTo().Frame(editForm);
            IWebElement firstName = driver.FindElement(By.Id("FirstName"));
            //firstName.Click();
            firstName.SendKeys("NFName");

            //*[@id="LastName"]
            IWebElement lastName = driver.FindElement(By.Id("LastName"));
            lastName.Click();
            lastName.SendKeys("NLName");

            //*[@id="PreferedName"]
            IWebElement preferredName = driver.FindElement(By.Id("PreferedName"));
            preferredName.SendKeys("NPName");

            //*[@id="Phone"]
            IWebElement phone = driver.FindElement(By.Id("Phone"));
            phone.SendKeys("1234");

            //*[@id="Mobile"]
            IWebElement mobile = driver.FindElement(By.Id("Mobile"));
            mobile.SendKeys("1234");

            //*[@id="email"]
            IWebElement email = driver.FindElement(By.Id("email"));
            email.SendKeys("test@gmail.com");

            //*[@id="Fax"]
            IWebElement fax = driver.FindElement(By.Id("Fax"));
            fax.SendKeys("1234");

            //*[@id="autocomplete"]
            IWebElement autocomplete = driver.FindElement(By.Id("autocomplete"));
            autocomplete.SendKeys("N-Address");

            //*[@id="Street"]
            IWebElement street = driver.FindElement(By.Id("Street"));
            street.SendKeys("N-street");

            //*[@id="City"]
            IWebElement city = driver.FindElement(By.Id("City"));
            city.SendKeys("N-City");

            //*[@id="Postcode"]
            IWebElement postcode = driver.FindElement(By.Id("Postcode"));
            postcode.SendKeys("1234"); ;

            //*[@id="Country"]
            IWebElement country = driver.FindElement(By.Id("Country"));
            country.SendKeys("N-Country");

            //*[@id="submitButton"]
            IWebElement submitButton = driver.FindElement(By.Id("submitButton"));
            submitButton.Click();

            driver.SwitchTo().DefaultContent();
            IWebElement sameAsAboveCheckbox = driver.FindElement(By.Id("IsSameContact"));
            sameAsAboveCheckbox.Click();

            IWebElement gstTextBox = driver.FindElement(By.Id("GST"));
            gstTextBox.SendKeys("N-GST");

            IWebElement saveContactButton = driver.FindElement(By.Id("submitButton"));
            saveContactButton.Click();

            //Click on Administration Menu
            IWebElement adminsTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a/span"));
            adminsTab.Click();

            //Click on Customers Sub-Menu
            IWebElement customerOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[1]/a"));
            customerOption.Click();

            IWebElement goToLastPageofCustomerRecords = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"clientsGrid\"]/div[4]/a[4]/span")));

            //IWebElement goToLastPageofCustomerRecords = driver.FindElement(By.XPath("//*[@id=\"clientsGrid\"]/div[4]/a[4]/span"));
            goToLastPageofCustomerRecords.Click();

            Thread.Sleep(2000);

            IWebElement lastCustomerElement = driver.FindElement(By.XPath("//*[@id=\"clientsGrid\"]/div[2]/table/tbody/tr[last()]/td[2]"));
            Assert.That(lastCustomerElement.Text == "N-Customer", "Customer record not created. Test Failed");
        }

        public void EditCustomersRecord(IWebDriver driver)
        {
            // click edit
            IWebElement editCustomerButton = driver.FindElement(By.XPath("//*[@id=\"clientsGrid\"]/div[2]/table/tbody/tr[last()]/td[4]/a[1]"));
            editCustomerButton.Click();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            IWebElement editCustomerWindow = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"detailWindow\"]/iframe")));
            driver.SwitchTo().Frame(editCustomerWindow);
            //*[@id="detailWindow"]/iframe

            //edit name
            IWebElement custName = driver.FindElement(By.Id("Name"));
            custName.Clear();
            custName.SendKeys("Edited Name");
            //*[@id="Name"]

            //edit contact button click
            IWebElement editCustomerPopUpButton = driver.FindElement(By.Id("EditContactButton"));
            editCustomerPopUpButton.Click();
            //*[@id="EditContactButton"]

            IWebElement editContactBtn = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"contactDetailWindow\"]/iframe")));
            driver.SwitchTo().Frame(editContactBtn);
            //*[@id="detailWindow"]/iframe

            // edit below
            //*[@id="FirstName"]
            IWebElement editFirstName = driver.FindElement(By.Id("FirstName"));
            editFirstName.Clear();
            editFirstName.SendKeys("Edited F Name");

            //*[@id="LastName"]
            IWebElement editLastName = driver.FindElement(By.Id("LastName"));
            editLastName.Clear();
            editLastName.SendKeys("Edited L Name");

            //*[@id="PreferedName"]
            IWebElement editedPreferredName = driver.FindElement(By.Id("PreferedName"));
            editedPreferredName.Clear();
            editedPreferredName.SendKeys("Edited N-PName");

            //*[@id="Phone"]
            IWebElement editedPhone = driver.FindElement(By.Id("Phone"));
            editedPhone.Clear();
            editedPhone.SendKeys("123456");

            //*[@id="Mobile"]
            IWebElement editedMobile = driver.FindElement(By.Id("Mobile"));
            editedMobile.Clear();
            editedMobile.SendKeys("123456");

            //*[@id="email"]
            IWebElement editedEmail = driver.FindElement(By.Id("email"));
            editedEmail.Clear();
            editedEmail.SendKeys("editedtest@gmail.com");

            //*[@id="Fax"]
            IWebElement editedFax = driver.FindElement(By.Id("Fax"));
            editedFax.Clear();
            editedFax.SendKeys("123456");

            //*[@id="autocomplete"]
            IWebElement editedAutocomplete = driver.FindElement(By.Id("autocomplete"));
            editedAutocomplete.Clear();
            editedAutocomplete.SendKeys("Edited N-Address");

            //*[@id="Street"]
            IWebElement editedStreet = driver.FindElement(By.Id("Street"));
            editedStreet.Clear();
            editedStreet.SendKeys("Edited N-street");

            //*[@id="City"]
            IWebElement editedCity = driver.FindElement(By.Id("City"));
            editedCity.Clear();
            editedCity.SendKeys("Edited N-City");

            //*[@id="Postcode"]
            IWebElement editedPostcode = driver.FindElement(By.Id("Postcode"));
            editedPostcode.Clear();
            editedPostcode.SendKeys("123456");

            //*[@id="Country"]
            IWebElement editedCountry = driver.FindElement(By.Id("Country"));
            editedCountry.Clear();
            editedCountry.SendKeys("Edited N-Country");

            IWebElement saveEditedCust = driver.FindElement(By.Id("submitButton"));
            saveEditedCust.Click();
            //save 
            //*[@id="submitButton"]

            driver.SwitchTo().DefaultContent();
            IWebElement editCustomerrWindow = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"detailWindow\"]/iframe")));
            driver.SwitchTo().Frame(editCustomerrWindow);
            IWebElement editedGstTextBox = driver.FindElement(By.Id("GST"));
            editedGstTextBox.Clear();
            editedGstTextBox.SendKeys("Edited NGST");

            IWebElement saveEditedContactButton = driver.FindElement(By.Id("submitButton"));
            saveEditedContactButton.Click();

            driver.SwitchTo().DefaultContent();
            //IWebElement refreshCustomerGrid = driver.FindElement(By.XPath("//*[@id=\"clientsGrid\"]/div[4]/a[5]/span"));
            //refreshCustomerGrid.Click();

            IWebElement lastCustomerElementt = driver.FindElement(By.XPath("//*[@id=\"clientsGrid\"]/div[2]/table/tbody/tr[last()]/td[2]"));

            Assert.That(lastCustomerElementt.Text == "Edited Name", "Customer record not updted. Test Failed");
            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.CssSelector(".k-loading-image")));
        }

        public void DeleteCustomersRecord(IWebDriver driver)
        {
            //Delete newly added customer
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            IWebElement deleteCustomerButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"clientsGrid\"]/div[2]/table/tbody/tr[last()]/td[4]/a[2]")));
            deleteCustomerButton.Click();

            // Wait for the alert to be present 
            IAlert alertPopup = wait.Until(ExpectedConditions.AlertIsPresent());

            // Handle the alert (Click OK)
            alertPopup.Accept();

            IWebElement checkLastRecord = driver.FindElement(By.XPath("//*[@id=\"clientsGrid\"]/div[2]/table/tbody/tr[last()]/td[2]"));

            Assert.That(checkLastRecord.Text != "Edited Name", "Customer record is not deleted successfully. Test Failed");
        }
    }
}
