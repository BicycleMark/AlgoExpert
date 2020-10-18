using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Transactions;

namespace Problems
{
    public class LongestPeakQuestion
    {
        public static int LongestPeak(int[] array)
        {
            int longestPeak = 0;
            int idx = 1;        
            List<int> ndxPeak = new List<int>();
            while (idx < array.Length-1)
            {
                bool isPeak = array[idx - 1] < array[idx] &&
                              array[idx] > array[idx + 1];
                if (isPeak)
                {
                    ndxPeak.Add(idx);
                    idx += 2;
                }
                else
                    ++idx;
            }
            foreach (var ndx in ndxPeak)
            {
                int peakValue = array[ndx];
                int left = ndx - 1;
                int right = ndx + 1;

                while (left > 0 && array[left] > array[left - 1])
                    --left;
                while (right < array.Length-1 && array[right] > array[right+1])
                    ++right;
                longestPeak = Math.Max(longestPeak, right - left + 1);
            }
            return longestPeak;
        }
    }
}
