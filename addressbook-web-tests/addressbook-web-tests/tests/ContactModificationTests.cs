using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAdressbooksTests
{
    [TestFixture]
    public class ContactModificationTests : AuthTestBase
    {
        [Test]
        public void ContactModificationTest()
        {
            ContactData newData = new ContactData("Pumba", "Timon");

            if (app.Contacts.IsContactPresent())
            {
                return;
            }
            else
            {
                ContactData contact = new ContactData("Aboba", "Buba");
                app.Contacts.Create(contact);
            }
                app.Contacts.Modify(1, newData);
        }

    }
}
