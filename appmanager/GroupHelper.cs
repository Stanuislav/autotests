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
    public class GroupHelper : HelperBase
    {


        public GroupHelper(AplicationManager manager) : base(manager)
        { }

        public GroupHelper Create(GroupDate group)
        {
            manager.Navigator.OpenToPageGroup();
            IntiNewGroupCreation();
            FillGroupForm(group);
            SumbitGroupCreation();
            ReturnToGroupPage();
            return this;
        }
        public GroupHelper Modify(int p, GroupDate newData)
        {
            manager.Navigator.OpenToPageGroup();
            SelectGroup(p);
            InitGroupModification();
            FillGroupForm(newData);
            SumbitGroupModification();
            ReturnToGroupPage();
            return this;
        }

      
        public GroupHelper IntiNewGroupCreation()
        {
            driver.FindElement(By.Name("new")).Click();
            return this;
        }
        public GroupHelper FillGroupForm(GroupDate group)
        {
            driver.FindElement(By.Name("group_name")).Click();
            driver.FindElement(By.Name("group_name")).Clear();
            driver.FindElement(By.Name("group_name")).SendKeys(group.Name);
            driver.FindElement(By.Name("group_header")).Click();
            driver.FindElement(By.Name("group_header")).Clear();
            driver.FindElement(By.Name("group_header")).SendKeys(group.Header);
            driver.FindElement(By.Name("group_footer")).Click();
            driver.FindElement(By.Name("group_footer")).Clear();
            driver.FindElement(By.Name("group_footer")).SendKeys(group.Footer);
            return this;
        }

        public GroupHelper SumbitGroupCreation()
        {
            driver.FindElement(By.Name("submit")).Click();
            return this;
        }

        public GroupHelper ReturnToGroupPage()
        {
            driver.FindElement(By.LinkText("group page")).Click();
            return this;
        }


        public GroupHelper SelectGroup(int index)
        { 
            driver.FindElement(By.XPath("(//input[@name='selected[]'])[" + index + "]")).Click();
            return this;
            }

        public GroupHelper SumbitGroupModification()
        {
            driver.FindElement(By.Name("update")).Click();
            return this;
        }

        public GroupHelper InitGroupModification()
        {
            driver.FindElement(By.Name("edit")).Click();
            return this;
        }
    }
}
