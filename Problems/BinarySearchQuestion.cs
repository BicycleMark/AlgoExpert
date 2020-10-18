using NUnit.Framework.Constraints;
using System;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using System.Text;

namespace Problems
{
    public class BinarySearchQuestion
    {
        public static int BinarySearch(int[] array, int target)
        {
            return BinarySearch(array, target, 0, array.Length - 1);
        }
        public static int  BinarySearch(int []array,int target, int left, int right)
        {
            while (left <= right)
            {
                int middle = (left + right) / 2;
                int match = array[middle];
                if (match == target)
                {
                    return middle;
                }
                else if (target < match)
                {
                    right = middle - 1;
                }
                else
                    left = middle + 1;
            }
            return -1;
        }
    }
}
