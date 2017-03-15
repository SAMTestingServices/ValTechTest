using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Support.PageObjects;

namespace PageObjects
{
    public class ValTechWebSitePageMaster
    {
        /// <summary>
        /// I have created a Master Page for the site 
        /// All Other Page objects on the site inherit from this page
        /// It would contain all objects or methods that are common across 
        /// the website (and also properties / methods common across all
        /// websites) to avoid unneccessary code duplication.
        /// In this case, all that is needed is the element to locate the h1 tag.
        /// The xpath locator used is effective on all pages.
        /// </summary>
        
        private IWebDriver _driver;

        public ValTechWebSitePageMaster(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver,this);
        }

        public bool CheckPageSourceForText(string text)
        {
            
            return _driver.PageSource.Contains(text);
        }
        
        
        [FindsBy(How = How.XPath, Using = "(//h1)[1]")]
        [CacheLookup]
        public IWebElement H1TitleTag { get; set; }
    }
}
