using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace AutomationTaskC.PageObject
{
    public class ResultPage
    {
        private IWebDriver driver;

        public ResultPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        By dynamicName = By.PartialLinkText("Business Applications | Microsoft Dynamics 365");

        public DetailsPage clickOnlink()
        {
            driver.FindElement(dynamicName).Click();
            Thread.Sleep(3000);
            return new DetailsPage(driver);
        }

    }
}
