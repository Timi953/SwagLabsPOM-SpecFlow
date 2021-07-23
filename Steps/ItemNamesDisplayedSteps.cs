using NUnit.Framework;
using SwagLabsPOM.PageConstants;
using SwagLabsPOM.SwagLabsPageObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SwagLabsPOM.Steps
{
    [Binding]
    public class ItemNamesDisplayedSteps
    {
        
        [Given(@"I navigate to the app")]
        public void GivenINavigateToTheApp()
        {
            DriverCollection.driver.Navigate().GoToUrl(LandingPageConstants.landingURL);
        }

        [Given(@"i login")]
        public void GivenILogin()
        {
            LandingPage landingPage = new LandingPage();
            landingPage.LoginOperation(UserConstants.ID_STANDARD_USER, UserConstants.ID_PASSWORD);
        }

        [When(@"i look at the item names")]
        public void WhenILookAtTheItemNames()
        {
            HomePage home = new HomePage();
            home.ItemNamesDisplayed();
        }

        [Then(@"the names should be displayed")]
        public void ThenTheNamesShouldBeDisplayed()
        {
            HomePage home = new HomePage();
            Assert.IsTrue(home.ItemNamesDisplayed());
        }

    }
}
