using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace PageObjects
{
    public class CareersPage : ValTechWebSitePageMaster
    {

        
        private IWebDriver _driver;

        public CareersPage(IWebDriver driver):base(driver)
        {
            _driver = driver;
        }
    }
}
