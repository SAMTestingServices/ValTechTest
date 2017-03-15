using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace PageObjects
{
    public class ContactMenuPage : ValTechWebSitePageMaster
    {
        private IWebDriver _driver;

        public ContactMenuPage(IWebDriver driver):base(driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver,this);
        }


        [FindsBy(How = How.XPath, Using = "//*[@class='contactcountry']/ul[@class='contactcities']/li/a[contains(@href,'/about/contact')]")]
        [CacheLookup]
        public IList<IWebElement> OfficeLinks { get; set; }
        
    }
}
