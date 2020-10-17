using NUnit.Framework;
using Problems;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TestAlgoExpert
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }


        [Test]
        public void TestRiver1()
        {
            int[,] matrix = {  {1,0,0,1,0 },
                                {1,0,1,0,0 },
                                {0,0,1,0,1 },
                                {1,0,1,0,1 },
                                {1,0,1,1,0 }
                             };
            int[] expected = { 1, 2, 2, 2, 5 };
            var rivers = new Rivers();
            var received = rivers.Solve(matrix);
            Assert.AreEqual(expected.Length, received.Length);

        }
        [Test]
        public void TestRiver2()
        {
            int[,] matrix = {   {1,0,0,0,0 },
                                {1,0,0,0,0 },
                                {1,0,0,0,0 },
                                {1,0,0,0,0 },
                                {1,0,0,0,0 }
                             };
            int[] expected = { 5 };
            var rivers = new Rivers();
            var received = rivers.Solve(matrix);
            Assert.AreEqual(expected.Length, received.Length);

        }
        //[TestCase(2,1)]

        [TestCase(2, 1)]

        [TestCase(6, 5)]

        [Test]
        public void TestNtFib1(int val, int expected)
        {

            Assert.AreEqual(expected, NThFibonacci.GetNthFib(val));

        }


        int[] Parse(string str)
        {
            //return str.Select(int.Parse).ToArray();
            var s = str.Split(',');
            List<int> lst = new List<int>();
            foreach (var item in s)
            {
                lst.Add(int.Parse(item));
            }
            return lst.ToArray();
        }

        [TestCase("11,-1", 10, 3, 5, -4, 8, 11, 1, -1, 6)]

        [Test]
        public void TestTwoNumberSum(string expectedValuesCsv,
                                        int targetSum,
                                        params int[] input)
        {
            var expected = Parse(expectedValuesCsv);
            var val = ProblemTwoNumberSum.TwoNumberSum(input, targetSum);
            Assert.AreEqual(expected[0], val[0]);
            Assert.AreEqual(expected[1], val[1]);



        }
        [TestCase("11,-1", 10, 3, 5, -4, 8, 11, 1, -1, 6)]

        [Test]
        public void TestTwoNumberSumHash(string expectedValuesCsv,
                                       int targetSum,
                                       params int[] input)
        {
            var expected = Parse(expectedValuesCsv);
            var val = ProblemTwoNumberSum.TwoNumberSumHashed(input, targetSum);
            Assert.AreEqual(expected[0], val[0]);
            Assert.AreEqual(expected[1], val[1]);
        }

        [TestCase("11,-1", 10, 3, 5, -4, 8, 11, 1, -1, 6)]
        [Test]
        public void TestTwoNumberSumSorted(string expectedValuesCsv,
                                       int targetSum,
                                       params int[] input)
        {
            var expected = Parse(expectedValuesCsv);
            var val = ProblemTwoNumberSum.TwoNumberSorted(input, targetSum);
            Assert.AreEqual(targetSum, val[0] + val[1]);

        }


    }

    [TestFixture]
    public class TestRange
    {
        [TestCase(0, 0, 0)]
        [TestCase(4, 5, 5, 4)]
        [TestCase(0, 7, 1, 11, 3, 0, 15, 5, 2, 4, 10, 7, 12, 6)]
        [Test]
        public void TestLargestRange(int expectedStart, int expectedEnd, params int[] input)
        {
            var retVal = LargestRange.GetLargestRange(input);
            Assert.AreEqual(expectedStart, retVal[0]);
            Assert.AreEqual(expectedEnd, retVal[1]);

        }
    }
    [TestFixture]
    public class TestValidateSequence
    {
        [TestCase(true, "5, 1, 22, 25, 6, -1, 8, 10", "1, 6, -1, 10")]
        [Test]
        public void TestSequence(bool expected, string strArray, string strSequence)
        {

            var array = Util.Parse(strArray).ToList();
            var sequence = Util.Parse(strSequence).ToList();
            Assert.AreEqual(expected,
                            ProblemValidateSequence.IsValidSubsequence(array, sequence));

        }

    }

    [TestFixture]
    public class TestTopN
    {
        [TestCase("18,141,541", 141, 1, 17, -7, -17, -27, 18, 541, 8, 7, 7)]
        [Test]
        public void Test(string expectedVals, params int[] array)
        {
            int[] expectedArray;
            var str = expectedVals.Split(',');
            expectedArray = new int[str.Length];

            for (int k = 0; k < str.Length; k++)
            {
                expectedArray[k] = int.Parse(str[k]);
            }

            LargestThree.NLargest.TopN topn = new LargestThree.NLargest.TopN(str.Length);
            foreach (var num in array)
            {
                topn.Add(num);
            }

            var topVals = topn.TopVals;
            Assert.AreEqual(topVals.Length, expectedArray.Length);
            int i = 0;
            foreach (var n in expectedArray)
            {
                Assert.AreEqual(n, topVals[i++]);
            }
        }
    }
}