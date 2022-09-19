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
    public class UsersHelper:HelperBase
    {
        public object UpdateUserModification { get; private set; }

        public UsersHelper(AplicationManager manager) : base (manager)
        {
        }

        public UsersHelper create (DataUsers user)
        {
            manager.Navigator.OpenPageNewContact();
            CreationContact(user);
            ClickCreationContact();
            return this;
        }

        public UsersHelper Modify (int p , DataUsers newData)
        {
            SelectEditUser(p);
            CreationContact(newData);
            SumbitUserModification();
            return this;
        }

        public UsersHelper Delete(int p)
        {
            SelectEditUser(p);
            SumbitUserDelete();
            return this;

        }

        public UsersHelper SelectCheckBox(int i) // Выбор чек-бокса 
        {
            driver.FindElement(By.XPath("(//input[@name='selected[]'])[" + i + "]")).Click();
            return this;
        }
        public UsersHelper SumbitUserDelete()   //Нажать кнопку делите
        {
            driver.FindElement(By.XPath("(//input[@value='Delete'])")).Click();
            return this;
        }
        public UsersHelper SumbitUserModification()   //Нажатия кнопки обновить пользователя
        {
            driver.FindElement(By.Name("update")).Click();
            return this;
        }

        public UsersHelper SelectEditUser(int p) //выбор пользователя любого
        {
           driver.FindElement(By.XPath("(//a[@href='edit.php?id=" + p + "'])")).Click();
            return this;
       }

        //public UsersHelper SelectEditUser(int p) //выбор пользователя любого
       //{
        //    driver.FindElement(By.XPath("(//img[@alt='Edit'])//tr[][" + p + "]")).Click();
         // return this;
      // }


        public UsersHelper ClickCreationContact() //Нажимаем на кнопку создать контакт
        {
            driver.FindElement(By.XPath("//div[@id='content']/form/input[21]")).Click();
            return this;
        }


        public UsersHelper CreationContact(DataUsers user) //Заполнение полей при создании контактов
        {
            driver.FindElement(By.Name("firstname")).Click();
            driver.FindElement(By.Name("firstname")).Clear();
            driver.FindElement(By.Name("firstname")).SendKeys(user.Fistname);
            driver.FindElement(By.Name("middlename")).Clear();
            driver.FindElement(By.Name("middlename")).SendKeys(user.Middlename);
            return this;
        }

    }
}
