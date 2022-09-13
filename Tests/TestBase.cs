using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;


namespace WebAdressbokTests
{
    public class TestBase
    {
        protected AplicationManager app;
        

        [SetUp]
        public void SetupTest()
        {
            app = new AplicationManager();
            app.Navigator.Openpagehome();
            app.Auth.Login(new AccountData("admin", "secret"));
        }

        [TearDown]
        public void TeardownTest()
        {
        app.Stop();
        }
        
    }

}
