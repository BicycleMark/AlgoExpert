using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Problems
{
	public class BST
	{
		public int value;
		public BST left;
		public BST right;

		public BST(int value)
		{
			this.value = value;
		}
	}
	public class ClosestBST
    {
		public static int FindClosestValueInBst(BST tree, int target)
		{
			// Write your code here.
			return -1;
		}

		
	}
	[TestFixture]
	public class TestClosestBST
    {
		[TestCase(12,@"{
			  'nodes': [
				{'id': '10', 'left': '5', 'right': '15', 'value': 10},
				{'id': '15', 'left': '13', 'right': '22', 'value': 15},
				{ 'id': '22', 'left': null, 'right': null, 'value': 22},
				{ 'id': '13', 'left': null, 'right': '14', 'value': 13},
				{ 'id': '14', 'left': null, 'right': null, 'value': 14},
				{ 'id': '5', 'left': '2', 'right': '5-2', 'value': 5},
				{ 'id': '5-2', 'left': null, 'right': null, 'value': 5},
				{ 'id': '2', 'left': '1', 'right': null, 'value': 2},
				{ 'id': '1', 'left': null, 'right': null, 'value': 1}
			  ],
			  'root': '10'
			}")]
		[Test]
		public void TestBST(int expectedValue, string BSTJSON )
        {

        }

    }
}
