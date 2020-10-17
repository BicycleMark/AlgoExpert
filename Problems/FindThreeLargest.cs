using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml.Schema;

namespace Problems
{
    public class LargestThree
    {
        public class NLargest
        {
            public class TopN
            {
                List<int> ss = null;
                int[] topVals;
                public int[] TopVals
                {
                    get
                    {
                        var a = ss.OrderBy(x=>x);
                        return a.ToArray(); ;
                    }
                }
                public TopN(int value)
                {
                    ss = new List<int>();
                    int val = int.MinValue;
                    for (int i = 0; i < value; i++)
                    {
                        ss.Add(val);         
                    }
                }
                public void Add(int n)
                {                   
                    if (n < ss.Min())
                        return;
                    int removeVal;
                    ss = ss.OrderBy(x => x).ToList();
                    if (n > ss.Max())
                    {
                        removeVal = ss.Min();
                        ss.Remove(removeVal);
                        ss.Add(n);
                        return;
                    }
                    else
                    {
                        for (int i = 0; i <ss.Count; i++)
                        {
                            if (n >= ss[i])
                            {
                                ss.Remove(ss[i]);
                                ss.Add(n);
                                return;
                            }
                        }
                    }             
                }
            }     
        }
        public static int[] FindThreeLargestNumbers(int[] array)
        {
            NLargest.TopN topVals = new NLargest.TopN(3);
            foreach(var n in array)
            {
                topVals.Add(n);
            }
            return topVals.TopVals;
        }
    }
}
