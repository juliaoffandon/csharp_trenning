using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAdressbooksTests
{
    [TestFixture]
    public class GroupCreationTests : AuthTestBase
    {
        
        [Test]
        public void GroupCreationTest()
        {           
            GroupData group = new GroupData("buba");
            group.Header = "ziry";
            group.Footer = "aboba";
            
            app.Groups.Create(group);
            app.Auth.Logout();
        }
        
        [Test]
        public void EmptyGroupCreationTest()
        {
             GroupData group = new GroupData("");
            group.Header = "";
            group.Footer = "";
                                   
            app.Groups.Create(group);
            app.Auth.Logout();
        }
    }
}
