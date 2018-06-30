using System.Linq;

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
            array = FilterDigitClass.FilterDigit(new DigitPredicate(2),array);
            return array;
        }


        [TestCase(new int[] { 4, 2, 7, 1 }, ExpectedResult = new int[] { })]
        [TestCase(new int[] { 4, 3, 111981, 7, 1, 111100, -2 }, ExpectedResult = new int[] { 111100 })]
        [TestCase(new int[] { 4, 3, 7, 1 }, ExpectedResult = new int[] { })]
        public int[] FilterDigitTestCase2(int[] array)
        {
            array = FilterDigitClass.FilterDigit(new DigitPredicate(0), array);
            return array;
        }

        [TestCase()]
        public void FilterDigitTestCaseBigSizeArray()
        {
            int[] array = Enumerable.Range(int.MinValue/100,int.MaxValue/100).ToArray();

            int [] actual = FilterDigitClass.FilterDigit(new DigitPredicate(2), array);

            int[] expected = array.Where(x => new DigitPredicate(2).IsMatch(x)).ToArray();

            CollectionAssert.AreEqual(actual,expected);
        }

    }
}