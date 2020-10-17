using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Problems
{
    public class ThreeNumberSumQuestion
    {
        public static List<int[]> ThreeNumberSum(int[] array, int targetSum)
        {
            List<int[]> lstReturn = new List<int[]>();

            Dictionary<int[], int> twoItemSum = new Dictionary<int[], int>();
            for (int i = 0; i < array.Length-2; i++ )
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    twoItemSum.Add(new int[] { i, j }, array[i] + array[j]);
                }
            }
            foreach (var n in array)
            {
                int seekVal = targetSum - n;
                var lst = from kvp in twoItemSum 
                          where kvp.Value == seekVal 
                          select kvp;
                foreach (var kvp in lst)
                {
                    int[] twoNdx = kvp.Key;
                    int[] retItem = new int[3]
                       {array[twoNdx[0]], array[twoNdx[1]],n };
                    retItem = retItem.OrderBy(x => x).ToArray();
                    lstReturn.Add(retItem);
                }
            }
            return lstReturn;
        }
    }
}
