using Implementing_Specflow_TurnUpPortal.Pages;
using Implementing_Specflow_TurnUpPortal.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementing_Specflow_TurnUpPortal.Tests
{
    [TestFixture]
    public class Customers_Tests : CommonDriver
    {
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();

            // Perform Login Actions
            Login loginObj = new Login();
            loginObj.LoginActions(driver);

            // Navigate to Time and Materials Module from Default Landing Page
            Home homePageObj = new Home();
            homePageObj.NavigateToTMPage(driver);
        }

        [Test, Order(1)]
        public void CreateCustomerRecord_Test()
        {
            Customers customersObj = new Customers();
            customersObj.CreateCustomersRecord(driver);
        }

        [Test, Order(2)]
        public void EditCustomersRecord_Test()
        {
            Customers customersObj = new Customers();
            customersObj.EditCustomersRecord(driver);
        }

        [Test, Order(3)]
        public void DeleteCustomersRecord_Test()
        {
            Customers customersObj = new Customers();
            customersObj.DeleteCustomersRecord(driver);
        }

        [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }

    }
}
