using Microsoft.VisualStudio.TestTools.UnitTesting;
using FuggvenyKeszitesGyakorlasGyurisCsaba;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuggvenyKeszitesGyakorlasGyurisCsaba.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void DobokockaTestNagyobb()
        {
            bool actual = Program.Dobokocka(12);
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void DobokockaTestKisebb()
        {
            bool actual = Program.Dobokocka(0);
            Assert.IsFalse(actual);
        }
        [TestMethod()]
        public void DobokockaTestBenneVan()
        {
            bool actual = Program.Dobokocka(4);
            Assert.IsTrue(actual);
        }
    }
}