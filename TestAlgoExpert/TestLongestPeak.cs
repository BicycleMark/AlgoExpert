using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Problems;

namespace TestAlgoExpert
{
    [TestFixture]
    public class TestLongestPeak
    {
        [TestCase(6,1, 2, 3, 3, 4, 0, 10, 6, 5, -1, -3, 2, 3)]
        [TestCase(5,5, 4, 3, 2, 1, 2, 10, 12, -3, 5, 6, 7, 10)]
        [TestCase(3, 1, 3, 2)]
        [Test]
        public void Test(int expected, params int[] array)
        {
            Assert.AreEqual(expected, LongestPeakQuestion.LongestPeak( array));
        }
    }
}
