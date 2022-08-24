using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAdressbooksTests
{
    [TestFixture]
    public class GroupRemovalTests : AuthTestBase
    {
        
        [Test]
        public void GroupRemovalTest()
        {
            if (!app.Groups.IsGroupPresent())
            
            {
                GroupData group = new GroupData("buba");
                group.Header = "ziry";
                group.Footer = "aboba";

                app.Groups.Create(group);
            }
            app.Groups.Remove(1);
        }                              
    }
}

