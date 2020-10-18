using System;
using System.Collections.Generic;
using System.Text;

namespace Problems
{
    public class BubbleSortQuestion
    {
        public static int[] BubbleSort(int[] array)
        {
            bool isSorted = false;
            while (!isSorted)
            {
                int swapCount = 0;
                for (int i = 0; i <= array.Length - 2; i++)
                { 
                    
                    if (array[i] > array[i+1])
                    {
                        Swap(array, i, i + 1);
                        ++swapCount;
                    }
                }
                isSorted = swapCount == 0;
            }
            return array;
        }

        private static void Swap(int[] array, int i, int j)
        {

            int tempVal = array[i];
            array[i] = array[j];
            array[j] = tempVal;
        }
    }

   
}
