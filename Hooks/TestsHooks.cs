using BoDi;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace AutomationTaskC.Hooks
{
    [Binding]
    public sealed class TestsHooks
    {
        private readonly IObjectContainer _container;

        public TestsHooks(IObjectContainer container) 
        {
            //assigning the internal variable to the container object

            _container = container;

        }


        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario()
        {
            //Launch browser and register by passing the driver object
            Console.WriteLine("Running before scenario...");
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            _container.RegisterInstanceAs<IWebDriver>(driver);

        }

        [AfterScenario]
        public void AfterScenario()
        {
            Console.WriteLine("Running after scenario...");

            var driver = _container.Resolve<IWebDriver>();

            if (driver != null)
            {
                driver.Quit();
            }

        }
    }
}