using System;
using System.Collections.Generic;
using System.Text;

namespace Problems
{
    public class Util
    {
        public static int[] Parse(string str)
        {
            //return str.Select(int.Parse).ToArray();
            var s = str.Split(',');
            List<int> lst = new List<int>();
            foreach (var item in s)
            {
                lst.Add(int.Parse(item));
            }
            return lst.ToArray();
        }
    }
}
