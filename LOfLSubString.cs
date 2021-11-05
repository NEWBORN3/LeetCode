using System;
using System.Collections.Generic;
namespace LeetCode
{
    public static class LOfLSubString
    {

        //window sliding technique
        public static int LengthOfLongestSubStirng(string theWord) 
        {
            if (String.IsNullOrEmpty(theWord))
                return 0;
            int i = 0;
            int j = 0;
            int max = 0;
            HashSet<int> uniqChar = new HashSet<int>();
            
            while (i < theWord.Length)
            {
                while (uniqChar.Contains(theWord[i]))
                {
                    uniqChar.Remove(theWord[j]);
                    j++;
                }
                uniqChar.Add(theWord[i]);
                max = Math.Max(max, i - j + 1);
                i++;
            }
            return max;
        }
    }
}