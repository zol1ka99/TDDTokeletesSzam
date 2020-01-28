using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDTokeletesSzam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDTokeletesSzam.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void OsztokSzamaTestHatosEset()
        {
            int number = 6;
            int actual = Program.OsztokSzama(number);
            int expected = 4;
            Assert.AreEqual(
                expected,
                actual,
                "Hatos bemenetre osztók száma nem négy"
                );

        }

        [TestMethod()]
        public void OsztokSzamaTestEgyesEset()
        {
            int number = 1;
            int actual = Program.OsztokSzama(number);
            int expected = 1;
            Assert.AreEqual(
                expected,
                actual,
                "Egyes bemenetre osztók száma nem négy"
                );

        }

        [TestMethod()]
        public void OsztokSzamaTestNullaEset()
        {
            try
            {
                int number = 0;
                int actual = Program.OsztokSzama(number);
            }
            catch (Exception e)
            {
                if (e.Message == "Nulla bemenet esetén osztók száma nem értelmezhető.")
                {
                    return;
                }
                else
                {
                    Assert.Fail("Nulla esetén rossz szövegű hibát dob");
                }
            }
            //ide jut ha nem dob hibát
            Assert.Fail("Nulla bemenetre nem dob hibát");

        }

        [TestMethod()]
        public void OsztokSzamaTestMinuszHatosEset()
        {
            int number = -6;
            int actual = Program.OsztokSzama(number);
            int expected = 4;
            Assert.AreEqual(
                expected,
                actual,
                "Mínusz hatos bemenetre osztók száma nem négy"
                );

        }

        [TestMethod()]
        public void TokeletesETestHat()
        {
            int number = 6;
            bool actual = Program.tokeletesE(number);
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void TokeletesETestHuszonNyolc()
        {
            int number = 28;
            bool actual = Program.tokeletesE(number);
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void TokeletesETestNyolcEzerSzazHuszonNyolc()
        {
            int number = 8128;
            bool actual = Program.tokeletesE(number);
            Assert.IsTrue(actual);
        }

        
    }
}