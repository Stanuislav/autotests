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
            app.Navigator.Openpagehome();
            app.Auth.Login(new AccountData("admin", "secret"));
            app.Navigator.OpenToPageGroup();
            app.Groups.IntiNewGroupCreation();
            GroupDate group = new GroupDate("1");
            group.Footer = "1";
            group.Header = "2";
            app.Groups.FillGroupForm(group);
            app.Groups.SumbitGroupCreation();
            app.Groups.ReturnToGroupPage();
            app.Navigator.Logout();
        }
    }
}
