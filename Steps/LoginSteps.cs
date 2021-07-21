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

        [Given(@"I have navigated to application")]
        public void GivenIHaveNavigatedToApplication()
        {
            DriverCollection.driver.Navigate().GoToUrl(LandingPageConstants.landingURL);
        }

        [Given(@"I enter username and password")]
        public void GivenIEnterUsernameAndPassword(Table table)
        {
            dynamic data = table.CreateDynamicInstance();

            landingPage.EnterUsernameAndPassword(data.UserName, data.Password);
        }

        [Given(@"I click login")]
        public void GivenIClickLogin()
        {
            landingPage.ClickLogin();
        }

        [Then(@"I should be logged in the application")]
        public void ThenIShouldBeLoggedInTheApplication()
        {
            Assert.That(LandingPage.GetCurrentUrl(), Is.EqualTo("https://www.saucedemo.com/inventory.html"));
        }


    }
}
