using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace PageObjects
{
    public class WorkPage : ValTechWebSitePageMaster
    {
        private IWebDriver _driver;

        public WorkPage(IWebDriver driver):base(driver)
        {
            _driver = driver;
        }
    }
}
