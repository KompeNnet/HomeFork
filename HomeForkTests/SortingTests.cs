using HomeFork.Helpers;
using NUnit.Framework;
using System;

namespace HomeForkTests
{
    [TestFixture]
    public class SortingTests
    {
        [TestCase(new int[] { 5, 2, 8, 10, 1 })]
        [TestCase(new int[] { 1, 5, 4, 2, 7, 9, 0, 456, 4, 34, 13, 87 })]
        [TestCase(new int[] { 52, 3, 1, 21, 81, -29, 27, -68, -18, -19, -98, 52, -74, 98, 59, 91 })]
        public void BubbleSort_SortsCorrectly(int[] values)
        {
            var result = SortingManager.SortWithBubbles(values);
            Array.Sort(values);

            Assert.AreEqual(values, result);
        }

        [TestCase(new int[] { 5, 2, 8, 10, 1 })]
        [TestCase(new int[] { 1, 5, 4, 2, 7, 9, 0, 456, 4, 34, 13, 87 })]
        [TestCase(new int[] { 52, 3, 1, 21, 81, -29, 27, -68, -18, -19, -98, 52, -74, 98, 59, 91 })]
        public void MergeSort_SortsCorrectly(int[] values)
        {
            var result = SortingManager.DoDatMergeSort(values);
            Array.Sort(values);

            Assert.AreEqual(values, result);
        }
    }
}
