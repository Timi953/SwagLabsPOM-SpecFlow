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
        HomePage homePage = new HomePage();
        LandingPage landingPage = new LandingPage();


        [Given(@"I navigate to the app")]
        public void GivenINavigateToTheApp()
        {
            DriverCollection.driver.Navigate().GoToUrl(LandingPageConstants.landingURL);
        }

        [Given(@"i login")]
        public void GivenILogin()
        {            
            landingPage.LoginOperation(UserConstants.ID_STANDARD_USER, UserConstants.ID_PASSWORD);
        }

        [When(@"i look at the item names")]
        public void WhenILookAtTheItemNames()
        {
            homePage.ItemNamesDisplayed();
        }

        [Then(@"the names should be displayed")]
        public void ThenTheNamesShouldBeDisplayed()
        {            
            Assert.IsTrue(homePage.ItemNamesDisplayed());
        }

    }
}
