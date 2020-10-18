using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Problems
{
    public class Monotonic
    {
        public static bool IsMonotonic(int[] array)
        {
            int direction = 0;
            
            for (int i = 1; i < array.Length; i++)
            {
                if (direction == 0)
                {
                    if (array[i-1] < array[i])
                    {
                        direction = 1;
                    }else if (array[i - 1] > array[i])
                    {
                        direction = -1;
                    }
                }else
                    switch (direction)
                    {
                        case (-1):
                            if (array[i] > array[i - 1])
                                return false;
                            break;
                        case (1):
                            if (array[i] < array[i - 1])
                                return false;
                            break;        
                    }
            }

            return true;
        }
    }
}
