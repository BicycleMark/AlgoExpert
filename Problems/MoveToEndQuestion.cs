using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Problems
{
    public class MoveToEndQuestion
    {
        public static List<int> MoveElementToEnd(List<int> array, int toMove)
        {
            int nItemsToMove = array.Where(x => x == toMove).Count();
            array.RemoveAll(x => x == toMove);
            for (int i = 0; i < nItemsToMove; i++)
            {
                array.Add(toMove);
            }
            return new List<int>(array);
        }
    }
}
