using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Problems
{
    public class SingleCycleCheck
    {
        
        public static bool HasSingleCycle(int[] array)
        {
            int[] visited = new int[array.Length];
            //visited[0] = ;
            int currentItem = 0;
            int initialItem = 0;

            foreach (var n in array)
            {

                currentItem = getNext(currentItem, array);
                visited[currentItem]++;
               
            }
            // Write your code here.
            return (visited.Count(x => x != 1) == 0) && currentItem == initialItem;
        }

        int currentItem = 0;
        public static int getNext(int currIdx, int[] array)
        {
            int jump = array[currIdx];
            int nextIdx = (currIdx + jump) % array.Length;
            return nextIdx >= 0 ? nextIdx : nextIdx + array.Length;
        }
    }

   
}
