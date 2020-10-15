using NUnit.Framework;
using Problems;

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
            int [,] matrix = {  {1,0,0,1,0 },
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
       
        [TestCase(2,1)]
        
        [TestCase(6, 5)]
       
        [Test]
        public void TestNtFib1(int val, int expected)
        {

            Assert.AreEqual(expected, NThFibonacci.GetNthFib(val));

        }
    }
}