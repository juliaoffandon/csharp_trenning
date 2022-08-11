﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace WebAdressbooksTests
{
    [TestFixture]
    public class GroupModificationTests : TestBase
    {
        [Test]
        public void GroupModificationTest()
        {
            GroupData newData = new GroupData("booo");
            newData.Header = "clepa";
            newData.Footer = "bubiboba";

            app.Groups.Modify(1, newData);
        }
    }
}
