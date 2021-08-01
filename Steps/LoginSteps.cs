using NUnit.Framework;
using SwagLabsPOM.PageConstants;
using SwagLabsPOM.SwagLabsPageObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SwagLabsPOM.Steps
{
    [Binding]
    public class LoginSteps : DriverCollection
    {
        LandingPage landingPage = new LandingPage();
              

        [Given(@"User has navigated to the application")]
        public void GivenUserHasNavigatedToTheApplication()
        {
            driver.Navigate().GoToUrl(LandingPageConstants.landingURL);
        }

        [When(@"User enters (.*) and (.*)")]
        public void WhenUserEntersAnd(string username, string password)
        {
            landingPage.EnterUsernameAndPassword(username, password);
        }

        [When(@"User clicks login")]
        public void WhenUserClicksLogin()
        {
            landingPage.ClickLogin();
        }

        [Then(@"User should be logged in the application")]
        public void ThenUserShouldBeLoggedInTheApplication()
        {
            Assert.That(GetCurrentUrl(), Is.EqualTo("https://www.saucedemo.com/inventory.html"));
        }

    }
}
