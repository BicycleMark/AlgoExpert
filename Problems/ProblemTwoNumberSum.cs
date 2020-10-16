using System;
using System.Collections.Generic;
using System.Text;

namespace Problems
{
    public class ProblemTwoNumberSum
    {
        public static int[] TwoNumberSum(int[] array, int targetSum)
        {
            int[] retVal = null; 
            for (int x = 0; x < array.Length; x++)
            {
                for (int y = x+1; y < array.Length; y++)
                {
                    if (array[x]+array[y] == targetSum )
                    {
                       
                        return new int[] { array[x], array[y] };
                    }
                }
            }
            return new int[0];
        }
    }
}
