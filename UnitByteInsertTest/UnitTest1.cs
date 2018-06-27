using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ByteInsertLogic;

namespace UnitByteInsertTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int actual = ByteInsert.InsertNumber(15, 15, 0, 0);
            int expected = 15;

            Assert.AreEqual(actual,expected);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int actual = ByteInsert.InsertNumber(8, 15, 0, 0);
            int expected = 9;

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int actual = ByteInsert.InsertNumber(8, 15, 3, 8);
            int expected = 120;

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void TestMethod4()
        {
            int actual = ByteInsert.InsertNumber(-8, -15, 0, 0);
            int expected = -7;

            Assert.AreEqual(actual, expected);
        }
    }
}
