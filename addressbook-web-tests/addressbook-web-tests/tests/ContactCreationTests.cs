using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAdressbooksTests
{
    [TestFixture]
    public class ContactCreationTests : AuthTestBase
    {
        
        [Test]
        public void ContactCreationTest()
        {           
            ContactData contact = new ContactData("Aboba", "Buba");
            
            app.Contacts.Create(contact);
            app.Auth.Logout();
        }                                                
    }
}
