using Microsoft.VisualStudio.TestTools.UnitTesting;
using TesztelesVaros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesztelesVaros.Tests
{
    [TestClass()]
    public class VarosTaroloTests
    {
        [TestMethod()]
        public void EllenorizVarosNevMegfeleloETestVarosNevNemNagyBetuvelKezdodik()
        {
            VarosTarolo vt = new VarosTarolo("Szeged");
            if (!vt.EllenorizVarosNevMegfeleloE())
            {
                Assert.Fail("A város név nagy betűvel kezdődik mégsem dob hibát");
            }
            Assert.Fail();
        }
    }
}