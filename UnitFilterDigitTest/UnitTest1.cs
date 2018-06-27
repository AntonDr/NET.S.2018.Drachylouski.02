using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FilterDigitLogic;

namespace UnitFilterDigitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int [] array = new int[]{1,2,22,33,55553,13};

            int[] actual = array.FilterDigit(new DigitThreePredicate());

            int[] expected = new[] {33, 55553, 13};

            for (int i = 0; i < actual.Length; i++)
            {
                Assert.AreEqual(actual[i],expected[i]);
            }
        }
    }
}
