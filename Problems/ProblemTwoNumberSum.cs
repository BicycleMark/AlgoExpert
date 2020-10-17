using System;
using System.Collections.Generic;
using System.Linq;
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
        public static int[] TwoNumberSumHashed(int[] array, int targetSum)
        {
            HashSet<int> hs = array.ToHashSet();          
            foreach (var x in array)
            {
                int y = targetSum - x;
                if (hs.Contains(y) && y != x)
                    return (new int[] { x, y });

            }
            return new int[0];
        }

        public static int[] TwoNumberSorted(int[] array, int targetSum)
        {
            array = array.OrderBy(x => x).ToArray();
            int left = 0;
            int right = array.Length - 1;
            while (left < right)
            {
                int currentSum = array[left] + array[right];
                if (currentSum == targetSum)
                {
                    return new int[] { array[left], array[right] };
                }else if (currentSum < targetSum)
                {
                    left++;

                }else if (currentSum > targetSum)
                {
                    right--;
                }
            }
            return new int[0];
        }
    }
}
