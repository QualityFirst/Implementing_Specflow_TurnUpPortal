using Implementing_Specflow_TurnUpPortal.Pages;
using Implementing_Specflow_TurnUpPortal.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace Implementing_Specflow_TurnUpPortal.StepDefinitions
{
    [Binding]
    public class TimeAndMaterialsStepDefinitions : CommonDriver
    {
        [Given(@"I logged into TurnUp portal successfully")]
        public void GivenILoggedIntoTurnUpPortalSuccessfully()
        {
            // Open Chrome Browser
            driver = new ChromeDriver();

            // Login page object initialization and definition
            Login loginPageObj = new Login();
            loginPageObj.LoginActions(driver);
        }

        [When(@"I navigate to Time and Material page")]
        public void WhenINavigateToTimeAndMaterialPage()
        {
            // Home page object initialization and definition
            Home homePageObj = new Home();
            homePageObj.NavigateToTMPage(driver);
        }

        [When(@"I create a time record")]
        public void WhenICreateATimeRecord()
        {
            // TM page object initialization and definition
            TimeAndMaterials tMPageObj = new TimeAndMaterials();
            tMPageObj.CreateTimeRecord(driver);
        }

        [Then(@"the record should be created successfully")]
        public void ThenTheRecordShouldBeCreatedSuccessfully()
        {
            TimeAndMaterials tMPageObj = new TimeAndMaterials();

            string newCode = tMPageObj.GetCode(driver);
            string newDescription = tMPageObj.GetDescription(driver);
            string newPrice = tMPageObj.GetPrice(driver);

            Assert.That(newCode == "N-1", "Actual Code and expected Code do not match.");
            Assert.That(newDescription == "N-1-Description", "Actual Description and expected Description do not match.");
            Assert.That(newPrice == "$20.00", "Actual Price and expected Price do not match.");
        }

        [When(@"I update the '([^']*)' and '([^']*)' on an existing Time record")]
        public void WhenIUpdateAnExistingTimeRecord(string code, string description)
        {
            TimeAndMaterials tMPageObj = new TimeAndMaterials();
            tMPageObj.EditTimeRecord(driver, code, description);
        }

        [Then(@"the record should have the updated '([^']*)' and '([^']*)'")]
        public void ThenTheRecordShouldHaveTheUpdatedAnd(string code, string description)
        {
            TimeAndMaterials tMPageObj = new TimeAndMaterials();

            string editedCode = tMPageObj.GetEditedCode(driver);
            string editedDescription = tMPageObj.GetEditedDescription(driver);

            Assert.That(editedCode == code, "Expected Edited Code and actual edited code do not match.");
            Assert.That(editedDescription == description, "Expected Edited Description and actual edited description do not match.");
        }

        [When(@"I delete an existing record")]
        public void WhenIDeleteAnExistingRecord()
        {
            // Delete Time Record
            TimeAndMaterials tMPageObj = new TimeAndMaterials();
            tMPageObj.DeleteTimeRecord(driver);
        }

        [Then(@"the record should not be present on the table")]
        public void ThenTheRecordShouldNotBePresentOnTheTable()
        {
            TimeAndMaterials tMPageObj = new TimeAndMaterials();

            string editedCode = tMPageObj.GetEditedCode(driver);
            string editedDescription = tMPageObj.GetEditedDescription(driver);

            Assert.That(editedCode != "N-EditedRecord", "Time record is not deleted successfully. Test Failed");
            Assert.That(editedDescription != "N-3-Description", "Expected Edited Description and actual edited description do not match.");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            // Close the browser and quit the WebDriver session
            driver.Quit();
        }
    }
}
