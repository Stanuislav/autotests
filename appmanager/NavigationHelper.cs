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

        public NavigationHelper(IWebDriver driver, string baseURL)
            : base(driver)
        {
            this.baseURL = baseURL;
        }



        public void Openpagehome()
        {
            driver.Navigate().GoToUrl(baseURL);
        }
        public void GoToHomePage()
        {
            driver.FindElement(By.LinkText("home page")).Click();
        }


        public void OpenPageNewContact()
        {
            driver.FindElement(By.LinkText("add new")).Click();
        }

        public void OpenToPageGroup()
        {
            driver.FindElement(By.LinkText("groups")).Click();
        }
        public void Logout() //Выход
        {
            driver.FindElement(By.LinkText("Logout")).Click();
        }

    }
}
