using Microsoft.VisualStudio.TestTools.UnitTesting;
using ValosSzam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValosSzam.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void KorlemezVanETestBenneVanE()
        {
            Pont p = new Pont();
            p.a = 0;
            p.b = 0;
            Kor k = new Kor();
            k.x = 0;
            k.y = 0;
            k.r = 1;
            Assert.IsTrue(Program.KorlemezVanE(p, k));
        }

        [TestMethod()]
        public void KorlemezVanETestRajtaVanE()
        {
            Pont p = new Pont();
            p.a = 0;
            p.b = 0;
            Kor k = new Kor();
            k.x = 0;
            k.y = 0;
            k.r = 1;
            Assert.IsTrue(Program.KorlemezVanE(p, k));
        }

        [TestMethod()]
        public void KorlemezVanETestKivulVanE()
        {
            Pont p = new Pont();
            p.a = 0;
            p.b = 5;
            Kor k = new Kor();
            k.x = 0;
            k.y = 0;
            k.r = 1;
            Assert.IsFalse(Program.KorlemezVanE(p, k));
        }
    }
}