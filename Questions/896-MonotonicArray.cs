﻿using System;
namespace questions
{
    // https://leetcode.com/contest/weekly-contest-100/problems/monotonic-array/

    //An array is monotonic if it is either monotone increasing or monotone decreasing.
    //An array A is monotone increasing if for all i <= j, A[i] <= A[j].  
    //An array A is monotone decreasing if for all i <= j, A[i] >= A[j].

    //Return true if and only if the given array A is monotonic.

    //Example 1:

    //Input: [1,2,2,3]
    //Output: true
    //Example 2:

    //Input: [6,5,4,4]
    //Output: true
    //Example 3:

    //Input: [1,3,2]
    //Output: false
    //Example 4:

    //Input: [1,2,4,5]
    //Output: true
    //Example 5:

    //Input: [1,1,1]
    //Output: true

    //Note:

    //1 <= A.length <= 50000
    //-100000 <= A[i] <= 100000

    public class MonotonicArray
    {
        public static bool IsMonotonic(int[] A)
        {
            bool incr = A[0] <= A[A.Length - 1];
            bool decr = A[0] >= A[A.Length - 1];

            if (decr)
            {
                for (int i = 1; i < A.Length; i++)
                {
                    if (A[i] <= A[i - 1] && decr)
                    {
                        continue;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else
            {
                for (int i = 1; i < A.Length; i++)
                {
                    if (A[i] >= A[i - 1] && incr)
                    {
                        continue;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
