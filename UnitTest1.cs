using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SwagLabsPOM.PageConstants;
using System;
using System.Threading;

namespace SwagLabsPOM.SwagLabsPageObject
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            LandingPage.open_driver(DriverCollection.Browser.Chrome);
            DriverCollection.driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
            DriverCollection.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [Test]
        public void StandarUserLogin()
        {
            
            LandingPage landingPage = new LandingPage();
            DriverCollection.driver.Navigate().GoToUrl(LandingPageConstants.landingURL);
                       
            landingPage.LoginOperation(UserConstants.ID_STANDARD_USER, UserConstants.ID_PASSWORD);

            Assert.That(LandingPage.GetCurrentUrl(), Is.EqualTo("https://www.saucedemo.com/inventory.html"));

            //WebDriverWait wait = new WebDriverWait(DriverCollection.driver, TimeSpan.FromSeconds(10));
            //var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id(ElementConstants.ID_MENU_BTN)));

            //Actions action = new Actions(DriverCollection.driver);
            //action.Click(element).Perform();

        }

        //[Test]
        //public void OPenCloseMenu()
        //{
        //    LandingPage landingPage = new LandingPage();
        //    DriverCollection.driver.Navigate().GoToUrl(LandingPage.landingURL);

        //    landingPage.LoginOperation("standard_user", "secret_sauce");

        //    Assert.That(LandingPage.GetCurrentUrl(), Is.EqualTo("https://www.saucedemo.com/inventory.html"));
        //    Assert.IsFalse(landingPage.burgerMenu.Displayed);
        //    WebDriverWait wait = new WebDriverWait(DriverCollection.driver, TimeSpan.FromSeconds(10));
        //    var isElVisible = wait.Until(condition =>
        //    {
        //        try
        //        {
        //            var elementToBeDisplayed = DriverCollection.driver.FindElement(By.Id(PageConstants.HomePageConstants.ID_MENU_BTN));
        //            return elementToBeDisplayed.Displayed;
        //        }
        //        catch (StaleElementReferenceException)
        //        {
        //            return false;
        //        }
        //        catch (NoSuchElementException)
        //        {
        //            return false;
        //        }
        //    });
        //    Actions action = new Actions(DriverCollection.driver);
        //    if (isElVisible) {

        //        action.Click(landingPage.burgerBtn).Perform();
        //    }
        //    Assert.IsTrue(landingPage.burgerMenu.Displayed);
        //    action.Click(landingPage.xBtn).Perform();
            
        //    isElVisible = wait.Until(condition =>
        //    {
        //        try
        //        {
        //            var elementToBeDisplayed = DriverCollection.driver.FindElement(By.ClassName(PageConstants.HomePageConstants.ID_MENU_WRAPPER));
        //            return elementToBeDisplayed.Displayed;
        //        }
        //        catch (StaleElementReferenceException)
        //        {
        //            return false;
        //        }
        //        catch (NoSuchElementException)
        //        {
        //            return false;
        //        }
        //    });

        //    Assert.IsFalse(isElVisible);
        //}



        [TearDown]
        public void TearDown()
        {
            DriverCollection.driver.Close();
            DriverCollection.driver.Quit();
            DriverCollection.driver.Dispose();
        }

        
    }
}