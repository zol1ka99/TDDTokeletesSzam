using Microsoft.VisualStudio.TestTools.UnitTesting;
using PontProjekt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PontProjekt.Tests
{
    [TestClass()]
    public class PontTests
    {
        [TestMethod()]
        public void origobanVanETestOrigobanVan()
        {
            Pont p = new Pont(0, 0);
            Assert.IsTrue(p.origobanVanE());
        }

        [TestMethod()]
        public void origobanVanETestNincsOrigoban()
        {
            Pont p = new Pont(1, 1);
            Assert.IsFalse(p.origobanVanE());
        }


        //y tengelyen vizsgálat
        [TestMethod()]
        public void yTengelyenVanETestIgaz()
        {
            Pont p = new Pont(0, 1);
            Assert.IsTrue(p.yTengelyenVanE());
        }

        [TestMethod()]
        public void yTengelyenVanETestHamis()
        {
            Pont p = new Pont(1, 0);
            Assert.IsFalse(p.yTengelyenVanE());
        }

        //x tengely vizsgálat
        [TestMethod()]
        public void xTengelyenVanETestIgaz()
        {
            Pont p = new Pont(0, 1);
            Assert.IsFalse(p.xTengelyenVanE());
        }

        [TestMethod()]
        public void xTengelyenVanETestHamis()
        {
            Pont p = new Pont(1, 0);
            Assert.IsTrue(p.xTengelyenVanE());
        }
    }
}