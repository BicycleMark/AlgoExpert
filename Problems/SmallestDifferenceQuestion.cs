using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problems
{
    public class SmallestDifferenceQuestion
    {
        public static int[] SmallestDifference(int[] arrayOne, int[] arrayTwo)
        {
            // Write your code here.
            arrayOne = arrayOne.OrderBy(x => x).ToArray();
            arrayTwo = arrayTwo.OrderBy(x => x).ToArray();
            int smallestDifferece = int.MaxValue;
            int idxOne = 0;
            int idxTwo = 0;
            int smallestDifference = int.MaxValue;
            int[] smallestPair = new int[2];
            while (idxOne < arrayOne.Length && idxTwo < arrayTwo.Length)
            {
                int firstNum = arrayOne[idxOne];
                int secondNum = arrayTwo[idxTwo];
                int difference = Math.Abs(firstNum - secondNum);
                if (difference == 0)
                {
                    return new int[] { firstNum, secondNum };
                }
                if (firstNum < secondNum)
                    ++idxOne;
                else if (secondNum < firstNum)
                    ++idxTwo;
                if (smallestDifferece > difference)
                {
                    smallestDifferece = difference;
                    smallestPair = new int[] { firstNum, secondNum };
                }
            }
            return smallestPair;
        }
    }
}
