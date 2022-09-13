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
           
            DataUsers user = new DataUsers("stass", "surhovetskiy");
            user.Lastname = "vas";
            app.Navigator
                .Logout();
        }
    }
}
