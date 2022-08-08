using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAdressbokTests
{
    [TestFixture]
    public class GroupCreationTests:TestBase
    {
        [Test]
        public void GroupCreationTest()
        {
            Openpagehome();
            Login(new AccountData("admin","secret"));
            OpenToPageGroup();
            IntiNewGroupCreation();
            GroupDate group = new GroupDate ("1");
            group.Footer = "1";
            group.Header = "2";
            FillGroupForm(group);
            SumbitGroupCreation();
            ReturnToGroupPage();
            Logout();
        }
    }
}
