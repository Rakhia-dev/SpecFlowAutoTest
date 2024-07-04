using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTaskC.PageObject
{
    public class DetailsPage
    {
        string pageTitle = "Business Applications | Microsoft Dynamics 365";
        By dynamicLogo = By.Id("uhfCatLogo");
        By sigInButton = By.Id("c-shellmenu_custom_button_outline_newtab_signin_bhvr100_right");
  
        private IWebDriver driver;

        public DetailsPage(IWebDriver driver)        {
            this.driver = driver;
        }   

        public String getTitle()
        {
            return driver.Title;
        }

        public void verifyDynamicPageDisplayed()
        {
            Thread.Sleep(3000);
            Assert.AreEqual(pageTitle,getTitle());
          
        }
    }
}
