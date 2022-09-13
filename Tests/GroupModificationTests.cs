using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAdressbokTests
{
    [TestFixture]
    public class GroupModificationTests: TestBase
    {
        [Test]
        public void GroupModificationTest()
        {
            GroupDate newData = new GroupDate("zzz");
            newData.Footer = "www";
            newData.Header = "eee";

            app.Groups.Modify(1, newData);

        }

    }
}
