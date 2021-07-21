using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Chrome;
using SwagLabsPOM.PageConstants;

namespace SwagLabsPOM.SwagLabsPageObject
{
     public class LandingPage : DriverCollection
     {

        public void ClickButton(IWebElement el)
        {
            el.Click();
        }

        

        #region Element locators
        //Element locators for Landing Page
        IWebElement usernameInput => driver.FindElement(By.Id(LandingPageConstants.ID_USERNAME_FLD));

        IWebElement passwordInput => driver.FindElement(By.Id(LandingPageConstants.ID_PASSWORD_FLD));

        IWebElement loginBtn => driver.FindElement(By.Id(LandingPageConstants.ID_LOGIN_BTN));

        #endregion

        #region Landing page methods
        //Methods for Landing Page
        public void EnterUsernameAndPassword(string username, string password)
        {
            usernameInput.SendKeys(username);
            passwordInput.SendKeys(password);
        }

        public void LoginOperation(string username, string password)
        {
            usernameInput.SendKeys(username);
            passwordInput.SendKeys(password);
            ClickButton(loginBtn);
        }

        public void ClickLogin()
        {
            loginBtn.Click();
        }

        #endregion
        


     }


}
