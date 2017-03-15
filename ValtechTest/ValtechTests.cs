using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using PageObjects;

namespace ValtechTest
{
    [TestClass]
    public class ValtechTests
    { 
       IWebDriver driver;


      

       
    
      [TestInitialize]
        public void TestSetup()
        {
            driver = new ChromeDriver();
            
         

            //This fails as Latest News does not exist at present.

        }

        [TestCleanup]
        public void TestTearDown()
        {
            driver.Dispose();

        }
        [TestMethod]
        public void AssertLatestNewsIsDisplayedOnHomePage()
        {
            
            var valtechHomePage = new HomePage(driver);

            valtechHomePage.GoTo();
            Assert.IsTrue(valtechHomePage.LatestNewsLink.Displayed);

            //This fails as Latest News does not exist at present.
            
        }

        
        /// Adding the following Test Case which asserts that Services 
        /// is displayed (since Latest news not present).
       
        [TestMethod]
        public void AssertServicesIsDisplayedOnHomePage()
        {
            
            var valtechHomePage = new HomePage(driver);

            valtechHomePage.GoTo();
            Assert.IsTrue(valtechHomePage.ServicesLink.Displayed);



        }

        [TestMethod]
        public void AssertH1TagCorrect_ServicesPage()
        {
           
            var valtechHomePage = new HomePage(driver);
            valtechHomePage.GoTo();

            valtechHomePage.ServicesLink.Click();

            var valtechServicesPage = new ServicesPage(driver);
           
            Assert.AreEqual(valtechServicesPage.H1TitleTag.Text,"Services");



        }
        [TestMethod]
        public void AssertH1TagCorrect_CasesPage()
        {
            
            var valtechHomePage = new HomePage(driver);
            valtechHomePage.GoTo();

            valtechHomePage.WorkLink.Click();

            var valtechWorkPage = new WorkPage(driver);

            Assert.AreEqual(valtechWorkPage.H1TitleTag.Text, "Work");



        }
        [TestMethod]
        public void AssertH1TagCorrect_JobsPage()
        {
            
            var valtechHomePage = new HomePage(driver);
            valtechHomePage.GoTo();

            valtechHomePage.CareersLink.Click();

            var valtechCareersPage = new CareersPage(driver);

            Assert.AreEqual(valtechCareersPage.H1TitleTag.Text, "Careers");



        }

        [TestMethod]
        public void GetNumberOfValtechOffices()
        {

            var valtechHomePage = new HomePage(driver);
            valtechHomePage.GoTo();

            valtechHomePage.ContactLink.Click();

            var valtechContactMenuPage = new ContactMenuPage(driver);

            int numberOfOffices = valtechContactMenuPage.OfficeLinks.Count;

            
            Console.WriteLine(String.Format("Number Of Offices are ={0}", valtechContactMenuPage.OfficeLinks.Count));

            Assert.IsTrue(numberOfOffices == 20);


        }


    }
}
