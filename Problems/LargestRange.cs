using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace Problems
{
    public class LargestRange
    {
        public static int[] GetLargestRange(int[] array)
        {
            int[] bestRange = new int[2];
            if (array.Length <= 1)
            {
                bestRange[0] = array[0];
                bestRange[1] = array[0];
                return bestRange;
            }
            if (array.Length <= 2)
            {
                array = array.OrderBy(x => x).ToArray();
                bestRange[0] = array[0];
                bestRange[1] = array[1];
                return bestRange;
            }

            Dictionary<int,bool> nums = new Dictionary<int,bool>();
            foreach (var n in array)
            {
                if (!nums.ContainsKey(n))
                    nums.Add(n, true);
            }
            int maxWidth = 0;
            int maxRangeStart = int.MinValue;
            int maxRangeEnd   = int.MinValue;

            foreach (var n in array)
            {
                if (nums[n] == true)
                {
                    //Find Left
                    int j = n;
                    int startRange = n;
                    int endRange = n;

                    while (nums.ContainsKey(j))
                    {
                        nums[j] = false;
                        --j;
                    }
                    startRange = j+1;
                    j = n + 1;
                    //Find Right
                    while (nums.ContainsKey(j))
                    {
                        nums[j] = false;
                        ++j;
                    }
                    endRange = j-1;

                    if (endRange - startRange > maxWidth)
                    {
                        maxRangeStart = startRange;
                        maxRangeEnd = endRange;
                        maxWidth = endRange - startRange + 1;
                    }
                }
            }
            bestRange[0] = maxRangeStart;
            bestRange[1] = maxRangeEnd;
            return bestRange;
        }
    }
}
