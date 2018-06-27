namespace NUnitByteInsertTest
{
    using System;

    using NUnit.Framework;

    using ByteInsertLogic;

    [TestFixture]
    public class FilterDigitTest
    {
        [TestCase(8, 15, 0, 0, ExpectedResult = 9)]
        [TestCase(8, 15, 3, 8, ExpectedResult = 120)]
        [TestCase(15, 15, 0, 0, ExpectedResult = 15)]
        public int ByteInsertTestCase(int a, int b, int i, int j)
        {
            return ByteInsert.InsertNumber(a, b, i, j);
        }

    }
}