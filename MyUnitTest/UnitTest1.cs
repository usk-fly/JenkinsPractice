using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var c = new MyLibrary.Class1();
            Assert.AreEqual(1, c.Return1());
        }

        [TestMethod]
        public void TestMethod2()
        {
            var c = new MyLibrary.Class1();
            Assert.AreEqual(2, c.Return2());
        }
    }
}
