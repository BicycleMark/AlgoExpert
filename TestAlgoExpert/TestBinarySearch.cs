using NUnit.Framework;
using Problems;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestAlgoExpert
{

    [TestFixture]
    public class TestBinarySearch
    {
        [TestCase(3, 33,  0, 1, 21, 33, 45, 45, 61, 71, 72, 73)]
        [Test]
        public void BinarySearch(int expected, int target,  params int[] array)
        {
            int nPass = BinarySearchQuestion.BinarySearch(array, target);
            Assert.AreEqual(expected, nPass);
        }
/*
        [TestCase(3, 33, 0, 1, 21, 33, 45, 45, 61, 71, 72, 73)]
        [Test]
        public void BinarySearch(int expected, int target, params int[] array)
        {
            int nPass = BinarySearchQuestion.BinarySearch(array, target);
            Assert.AreEqual(expected, nPass);
        }
*/
    }
}
