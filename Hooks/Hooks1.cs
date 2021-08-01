using SwagLabsPOM.SwagLabsPageObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SwagLabsPOM.Hooks
{
    [Binding]
    public sealed class Hooks1 : DriverCollection
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
            open_driver(Browser.Chrome);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Close();
            driver.Quit();
            driver.Dispose();
        }
    }
}
