﻿using System;
namespace questions
{
    // https://leetcode.com/contest/weekly-contest-100/problems/orderly-queue/

    //A string S of lowercase letters is given.Then, we may make any number of moves.
    //In each move, we choose one of the first K letters(starting from the left),
    //remove it, and place it at the end of the string.

    //Return the lexicographically smallest string we could have after any number of moves.

    //Example 1:
    //Input: S = "cba", K = 1
    //Output: "acb"
    //Explanation: 
    //In the first move, we move the 1st character("c") to the end, obtaining the string "bac".
    //In the second move, we move the 1st character("b") to the end, obtaining the final result "acb".
        
    //Example 2:
    //Input: S = "baaca", K = 3
    //Output: "aaabc"
    //Explanation: 
    //In the first move, we move the 1st character("b") to the end, obtaining the string "aacab".
    //In the second move, we move the 3rd character("c") to the end, obtaining the final result "aaabc".
     

    //Note:

    //1 <= K <= S.length <= 1000
    //S consists of lowercase letters only.

    public class OrderlyQ
    {
        public static string OrderlyQueue(string S, int K)
        {
            if (K == 1)
            {
                string ans = S;
                for (int i = 0; i < S.Length; ++i)
                {
                    string T = S.Substring(i) + S.Substring(0, i);
                    if (T.CompareTo(ans) < 0) 
                        ans = T;
                }
                return ans;
            }
            else
            {
                char[] ca = S.ToCharArray();
                Array.Sort(ca);
                return new String(ca);
            }
        }
    }
}