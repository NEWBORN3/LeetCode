using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
           string theWord = "abcabcbb";
           int res = LOfLSubString.LengthOfLongestSubStirng(theWord);
           Console.WriteLine(res);
        }
    }
}