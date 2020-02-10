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
        public void EllenorizVarosNevMegfeleloETestVarosNevNagyBetuvelKezdodik()
        {
            try
            {
                VarosTarolo vt = new VarosTarolo("Szeged");
                if (!vt.EllenorizVarosNevMegfeleloE())
                {
                    
                }
            }
            catch (Exception e)
            {
                Assert.Fail("A város név nagy betűvel kezdődik mégig hibát dob!");
            }
        }

        [TestMethod()]
        public void EllenorizVarosNevMegfeleloETestVarosNevMasodikKarakterKicsiE()
        {
            try
            {
                VarosTarolo vt = new VarosTarolo("Szeged");
                if (!vt.EllenorizVarosNevMegfeleloE())
                {

                }
            }
            catch (Exception e)
            {
                Assert.Fail("A város név kis betűvel folytatódik mégig hibát dob!");
            }
        }
    }
}