using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAdressbokTests
{ [TestFixture]
    public class DeleteUsers : TestBase
    {
        [Test]

        public void DeleteUser()
        {
            app.User.Delete(3);
        }
    }
}
