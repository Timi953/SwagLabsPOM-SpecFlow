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
            LandingPage.open_driver(DriverCollection.Browser.Chrome);
            DriverCollection.driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
            DriverCollection.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            DriverCollection.driver.Close();
            DriverCollection.driver.Quit();
            DriverCollection.driver.Dispose();
        }
    }
}
