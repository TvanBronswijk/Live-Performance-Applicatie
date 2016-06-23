using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LPWF.Controller;

namespace Test.LPWF.Controller
{
    [TestClass]
    public class BerekenTest
    {
        [TestMethod]
        public void Berekenen()
        {
            VerhuurController Verhuur = new VerhuurController();
            Assert.AreEqual(11, Verhuur.Berekenen(0, 1, 0, 0, 0, 22, 1));
            Assert.AreEqual(12, Verhuur.Berekenen(0, 1, 0, 0, 0, 100, 1));
            Assert.AreEqual(0, Verhuur.Berekenen(100, 1, 0, 0, 0, 22, 1));
        }
    }
}
