using OpenQA.Selenium;
using SwagLabsPOM.PageConstants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwagLabsPOM.SwagLabsPageObject
{
    public class HomePage : DriverCollection
    {

        #region Element locators
        //Element locators for Landing Page
        IWebElement menuBtn => driver.FindElement(By.Id(HomePageConstants.ID_MENU_BTN));

        IWebElement menuWrap => driver.FindElement(By.Id(HomePageConstants.ID_MENU_WRAPPER));

        IWebElement menuSidePanel => driver.FindElement(By.ClassName(HomePageConstants.ID_MENU_SIDEPANEL));

        IWebElement menuAllItemsBtn => driver.FindElement(By.Id(HomePageConstants.ID_MENU_ALLITEMS_BTN));

        IWebElement menuAboutBtn => driver.FindElement(By.Id(HomePageConstants.ID_MENU_ABOUT_BTN));

        IWebElement menuLogoutBtn => driver.FindElement(By.Id(HomePageConstants.ID_MENU_LOGOUT_BTN));

        IWebElement menuResetAppStateBtn => driver.FindElement(By.Id(HomePageConstants.ID_MENU_RESETAPPSTATE_BTN));

        IWebElement closeBtn => driver.FindElement(By.Id(HomePageConstants.ID_MENU_CLOSE_BTN));

        IWebElement itemsClass => driver.FindElement(By.ClassName(HomePageConstants.ID_ITEMS_CLASS));

        #endregion


        public bool ItemNamesDisplayed()
        {
            var itemsList = itemsClass.FindElements(By.ClassName(HomePageConstants.ID_ITEMS_CLASS));

            var isValid = true;

            for (int i = 0; i < itemsList.Count; i++)
            {
                
                if (itemsClass.Text == null)
                {
                    isValid = false;
                    break;
                }
            }
            return isValid;

        }
    }
}
