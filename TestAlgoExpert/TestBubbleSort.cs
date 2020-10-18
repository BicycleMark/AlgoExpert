using NUnit.Framework;
using Problems;
using System;
using System.Collections.Generic;
using System.Text;



namespace TestAlgoExpert
{
    [TestFixture]
    public class TestBubbleSort
    {
        [TestCase("2,3,5,5,6,8,9", 8, 5, 2, 9, 5, 6, 3)]
        [Test]
        public void Test(string expectedStr,params int[] array)
        {
            var expected = Problems.Util.Parse(expectedStr);
            var answer = BubbleSortQuestion.BubbleSort(array);
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(expected[i], answer[i]);
            }
        }

    }
}
