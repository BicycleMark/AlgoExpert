using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestAlgoExpert
{
    [TestFixture]
    public class TestMonotonic
    {
        [TestCase(true, -1, -5, -10, -1100, -1100, -1101, -1102, -9001)]
        [Test]
        public void Test(bool expected, params int[] array)
        {
            Assert.AreEqual(expected, Problems.Monotonic.IsMonotonic(array));
        }
    }
}
