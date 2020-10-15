using System;
using System.Collections.Generic;
using System.Text;

namespace Problems
{
    public class NThFibonacci
    {
		public static int GetNthFib(int n)
		{
			if (n <= 2)
			{
				return n - 1;
			}
			else
			{
				return GetNthFib(n - 1) + GetNthFib(n - 2);
			}
		}
	}
}
