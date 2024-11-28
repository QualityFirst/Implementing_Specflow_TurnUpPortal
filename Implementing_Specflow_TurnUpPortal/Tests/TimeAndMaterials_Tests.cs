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
    public class TimeAndMaterials_Tests : CommonDriver
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
        public void CreateTMRecord_Test()
        {
            TimeAndMaterials timeAndMaterialsObj = new TimeAndMaterials();
            timeAndMaterialsObj.CreateTimeRecord(driver);
        }

        [Test, Order(2)]
        public void EditTMRecord_Test()
        {
            TimeAndMaterials timeAndMaterialsObj = new TimeAndMaterials();
            timeAndMaterialsObj.EditTimeRecord(driver);
        }

        [Test, Order(3)]
        public void DeleteTMRecord_Test()
        {
            TimeAndMaterials timeAndMaterialsObj = new TimeAndMaterials();
            timeAndMaterialsObj.DeleteTimeRecord(driver);
        }

        [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }
    }
}