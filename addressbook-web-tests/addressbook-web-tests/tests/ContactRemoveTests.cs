using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace WebAdressbooksTests
{
    [TestFixture]
    public class ContactRemoveTests : TestBase
    {
        [Test]
        public void ContactRemoveTest()
        {           
            app.Contacts.Remove(1);
        }
    }
}
