using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAdressbokTests
{
    [TestFixture]
    public class CreationUsers:TestBase
    {
  
        [Test]
        public void CreationUser()
        {
            app.Navigator.Openpagehome();
            app.Auth.Login(new AccountData("admin", "secret"));
            app.Navigator.OpenPageNewContact();
            DataUsers user = new DataUsers("stass", "surhovetskiy");
            user.Lastname = "vas";
            app.User.CreationContact(user);
            app.User.ClickCreationContact();
            app.Navigator.GoToHomePage();
            app.Navigator.Logout();
        }
    }
}
