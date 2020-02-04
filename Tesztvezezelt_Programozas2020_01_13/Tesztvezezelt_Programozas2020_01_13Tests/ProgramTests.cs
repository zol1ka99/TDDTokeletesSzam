using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tesztvezezelt_Programozas2020_01_13;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tesztvezezelt_Programozas2020_01_13.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void IsEvenTestUnEvenCase()
        {
            int number = 3;
            bool actual = Program.IsEven(number);
            Assert.IsFalse(actual);
        }
    }
}