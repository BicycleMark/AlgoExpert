using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Problems;

namespace TestAlgoExpert
{
    [TestFixture]
    public class Palindrome
    {   
        [TestCase(true, "repaper")]
        [TestCase(false,"mark")]
        [TestCase(false,"houston")]
        [TestCase(true, "313")]
        [Test]
        public void PalindromeTest(bool expected, string value )
        {
            Assert.AreEqual(expected,Problems.Palindrome.Solve(value));
        }
    }
}
