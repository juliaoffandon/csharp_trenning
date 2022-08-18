using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace WebAdressbooksTests
{
    [TestFixture]
    public class ContactRemoveTests : AuthTestBase
    {
        [Test]
        public void ContactRemoveTest()
        {           
            if (app.Contacts.IsContactPresent())
            {
                return;
            }
            else
            {
                ContactData contact = new ContactData("Aboba", "Buba");
                app.Contacts.Create(contact);               
            }
            app.Contacts.Remove(1);

        }
    }
}
