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
            Openpagehome();
            Login(new AccountData("admin", "secret"));
            OpenPageNewContact();
            DataUsers user = new DataUsers("stass", "surhovetskiy");
            user.Lastname = "vas";
            CreationContact(user);
            ClickCreationContact();
            GoToHomePage();
            Logout();
        }
    }
}
