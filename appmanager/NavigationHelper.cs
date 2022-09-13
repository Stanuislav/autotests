using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;


namespace WebAdressbokTests
{
    public class NavigationHelper : HelperBase
    {

        private string baseURL;

        public NavigationHelper(AplicationManager manager, string baseURL)
            : base(manager)
        {
            this.baseURL = baseURL;
        }



        public NavigationHelper Openpagehome()
        {
            driver.Navigate().GoToUrl(baseURL);
            return this;
        }
        public NavigationHelper GoToHomePage()
        {
            driver.FindElement(By.LinkText("home page")).Click();
            return this;
        }


        public NavigationHelper OpenPageNewContact()
        {
            driver.FindElement(By.LinkText("add new")).Click();
            return this;
        }

        public NavigationHelper OpenToPageGroup()
        {
            driver.FindElement(By.LinkText("groups")).Click();
            return this;
        }
        public NavigationHelper Logout() //Выход
        {
            driver.FindElement(By.LinkText("Logout")).Click();
            return this;
        }

    }
}
