using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAdressbooksTests
{
    [TestFixture]
    public class ContactCreationTests : TestBase
    {
        
        [Test]
        public void ContactCreationTest()
        {
            OpenHomePage();
            Login(new AccountData("admin", "secret"));
            InitNewContactCreation();
            FillContactForm(new ContactData("Aboba", "Buba"));
            SubmitContactCreation();
            ReturnToHomePage();
            Logout();
        }                                                
    }
}
