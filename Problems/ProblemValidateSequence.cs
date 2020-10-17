using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problems
{
    public class ProblemValidateSequence
    {
        public static bool IsValidSubsequence(List<int> array, List<int> sequence)
        {
            int arrIdx = 0;
            int seqIdx = 0;
            while (arrIdx < array.Count && seqIdx < sequence.Count)
            {
                if (array[arrIdx] == sequence[seqIdx])
                    seqIdx++;
                ++arrIdx;
            }
            return seqIdx == sequence.Count; ;
        }
    }
}
