namespace FilterDigitTest
{
    using System;

    using NUnit.Framework;

    using FilterDigitLogic;

    [TestFixture]
    public class FilterDigitTest
    {
        [TestCase(new int[] { 4, 2, 7, 1 }, ExpectedResult = new int[] { 2 })]
        [TestCase(new int[] { 4, 3,111981, 7, 1 ,111100,-2}, ExpectedResult = new int[] { -2 })]
        [TestCase(new int[] { 4, 3, 7, 1 }, ExpectedResult = new int[] { })]
        public int[] FilterDigitTestCase(int[] array)
        {
            array = array.FilterDigit(new DigitTwoPredicate());
            return array;
        }


        [TestCase(new int[] { 4, 2, 7, 1 }, ExpectedResult = new int[] { })]
        [TestCase(new int[] { 4, 3, 111981, 7, 1, 111100, -2 }, ExpectedResult = new int[] { 111100 })]
        [TestCase(new int[] { 4, 3, 7, 1 }, ExpectedResult = new int[] { })]
        public int[] FilterDigitTestCase2(int[] array)
        {
            array = array.FilterDigit(new DigitZeroPredicate());
            return array;
        }

    }
}