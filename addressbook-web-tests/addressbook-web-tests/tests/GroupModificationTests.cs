using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace WebAdressbooksTests
{
    [TestFixture]
    public class GroupModificationTests : AuthTestBase
    {
        [Test]
        public void GroupModificationTest()
        {
            GroupData newData = new GroupData("booo");
            newData.Header = null;
            newData.Footer = null;

            if (app.Groups.IsGroupPresent())
            {
                return;
            }
            else
            {
                GroupData group = new GroupData("buba");
                group.Header = "ziry";
                group.Footer = "aboba";

                app.Groups.Create(group);
            }
            app.Groups.Modify(1, newData);
        }
    }
}
