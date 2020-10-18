using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using NUnit.Framework;
using Problems;

namespace TestAlgoExpert
{
    public partial class InputValues
    {
        [JsonProperty("arrayOne")]
        public int[] ArrayOne { get; set; }

        [JsonProperty("arrayTwo")]
        public int[] ArrayTwo { get; set; }
    }

    
    [TestFixture]
    public class TestSmallestDifference
    {
       [TestCase("{'arrayOne': [-1, 5, 10, 20, 28, 3], 'arrayTwo': [26, 134, 135, 15, 17]}",28,26)]
       [Test]
       public void Test(string jsonInput, params int[] expected)
       {
            var  testData = JsonConvert.DeserializeObject<InputValues>(jsonInput);
            var ret = SmallestDifferenceQuestion.SmallestDifference(testData.ArrayOne, testData.ArrayTwo);
            Assert.AreEqual(expected[0], ret[0]);
            Assert.AreEqual(expected[1], ret[1]);


        }

    }
}
