using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwagLabsPOM
{
    public class DriverCollection
    {
        public static IWebDriver driver;
        public static IWebDriver open_driver(Browser browser)
        {
            //driver = null;
            switch (browser)
            {
                case Browser.Chrome:
                    driver = new ChromeDriver();
                    driver.Manage().Window.Maximize();
                    break;

                case Browser.Firefox:
                    driver = new FirefoxDriver();
                    driver.Manage().Window.Maximize();
                    break;

                case Browser.InternetExplorer:
                    driver = new InternetExplorerDriver();
                    driver.Manage().Window.Maximize();
                    break;
            }
            return driver;
        }

        public enum Browser
        {
            Chrome,
            Firefox,
            InternetExplorer
        }

        public static string GetCurrentUrl()
        {
            return driver.Url;
        }
        public static IWebDriver GetSeleniumDriver()
        {
            return driver;
        }

        public static void SetSeleniumDriver(IWebDriver driverSelect)
        {
            driver = driverSelect;
        }


    }


}
