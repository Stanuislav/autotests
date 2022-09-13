using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;


namespace WebAdressbokTests
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {
        [Test]
        public void GroupCreationTest()
        {
           
            GroupDate group = new GroupDate("1");
            group.Footer = "1";
            group.Header = "2";
            app.Groups.Create(group);
            app.Navigator.Logout();
        }
        [Test]
        public void ZiroGroupCreationTest()
        { 

            GroupDate group = new GroupDate("");
            group.Footer = "";
            group.Header = "";
            app.Groups.Create(group);
            app.Navigator.Logout();
        }
    }
}
