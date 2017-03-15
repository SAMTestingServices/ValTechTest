using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace PageObjects
{
    public class HomePage:ValTechWebSitePageMaster
    {
        private readonly IWebDriver _driver;

        private string _homePageURL = "https://www.valtech.co.uk";

        

        public HomePage(IWebDriver driver):base(driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
        }

        
        public void GoTo()
        {
            _driver.Navigate().GoToUrl(_homePageURL);

        }

        [FindsBy(How = How.XPath, Using = "//*[@class='header__navigation__menu navigation__menu']//*[text()='Services']")]
        [CacheLookup]
        public IWebElement ServicesLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='header__navigation__menu navigation__menu']//*[text()='Latest News']")]
        [CacheLookup]
        public IWebElement LatestNewsLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='header__navigation__menu navigation__menu']//*[text()='Careers']")]
        [CacheLookup]
        public IWebElement CareersLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='header__navigation__menu navigation__menu']//*[text()='Work']")]
        [CacheLookup]
        public IWebElement WorkLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-icon='earth-contact']")]
        [CacheLookup]
        public IWebElement ContactLink { get; set; }
        

    }
}
