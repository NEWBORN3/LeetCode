using System;
using System.Collections.Generic;
namespace LeetCode
{
    public static class LOfLSubString
    {

        //window sliding technique
        public static int LengthOfLongestSubStirng(string theWord) 
        {
            int max = 0;
            var lastSeen = new Dictionary<char,int>();
            for (int j = 0, i = 0; j < theWord.Length; j++)
            {
                if (lastSeen.ContainsKey(theWord[j]))
                {
                    i = Math.Max(lastSeen[theWord[j]],i);
                }
                max = Math.Max(max, j - i + 1);
                lastSeen[theWord[j]] = j + 1;
            }

            return max;
        }
    }
}