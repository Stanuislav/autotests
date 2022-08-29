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
    public class CreationUsersHelper:HelperBase
    {

        public CreationUsersHelper(IWebDriver driver) : base (driver)
        {
        }

        public void ClickCreationContact() //Нажимаем на кнопку создать контакт
        {
            driver.FindElement(By.XPath("//div[@id='content']/form/input[21]")).Click();
        }


        public void CreationContact(DataUsers user) //Заполнение полей при создании контактов
        {
            driver.FindElement(By.Name("firstname")).Click();
            driver.FindElement(By.Name("firstname")).Clear();
            driver.FindElement(By.Name("firstname")).SendKeys(user.Fistname);
            driver.FindElement(By.Name("middlename")).Clear();
            driver.FindElement(By.Name("middlename")).SendKeys(user.Middlename);
        }

    }
}
