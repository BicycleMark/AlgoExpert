using NUnit.Framework;
using Problems;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestAlgoExpert
{
    [TestFixture]
    public class TestSingleCycle
    {
        [TestCase(true,2,3,1,-4,-4,2)]
        [Test]
        public void Test(bool expected, params int[] array)
        {
            Assert.AreEqual(expected,SingleCycleCheck.HasSingleCycle(array));
        }
    }
}
