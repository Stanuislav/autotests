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
    public class HelperBase
    {
        protected IWebDriver driver;
        protected AplicationManager manager;

        public HelperBase (AplicationManager manager)
        {
            this.manager = manager;
            this.driver = manager.Driver; }
    }
}
