using HomeFork.Helpers;
using NUnit.Framework;

namespace HomeForkTests
{
    [TestFixture]
    public class ExtensionsTests
    {
        [TestCase(new int[] { 5, 2, 8, 10, 1 }, 2, 3)]
        [TestCase(new int[] { 1, 5, 4, 2, 7, 9, 0, 456, 4, 34, 13, 87 }, 6, 3)]
        public void BubbleSort_SortsCorrectly(int[] values, int idx1, int idx2)
        {
            var copy = (int[]) values.Clone();

            values.Swap(idx1, idx2);

            Assert.AreEqual(copy[idx1], values[idx2]);
            Assert.AreEqual(copy[idx2], values[idx1]);
        }
    }
}
