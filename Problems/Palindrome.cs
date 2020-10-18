using System;
using System.Collections.Generic;
using System.Text;

namespace Problems
{
    public class Palindrome
    {
        public static bool Solve(string str)
        {
            int left = 0;
            int right = str.Length - 1;
            while (left <= right)
            {
                if (str[left] == str[right])
                {
                    ++left; --right;
                }else
                {
                    return false;
                }
            }
            return true;


        }
    }
}
