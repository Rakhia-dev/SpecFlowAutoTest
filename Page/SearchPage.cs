using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTaskC.PageObject
{
    public class SearchPage
    {
        private IWebDriver driver;

        public SearchPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        By searchTextbox = By.Id("APjFqb");

        public ResultPage searchText(string text)
        {
            driver.FindElement(By.Id("W0wltc")).Click();    
            Thread.Sleep(3000);
            driver.FindElement(searchTextbox).Click();
            driver.FindElement(searchTextbox).SendKeys(text);
            driver.FindElement(searchTextbox).SendKeys(Keys.Enter);
            Thread.Sleep(3000);
            return new ResultPage(driver);
        }
    }
}
