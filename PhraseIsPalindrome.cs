using System;
using System.Text.RegularExpressions;
namespace LeetCode
{
    public class PhraseIsPalindrome
    {
        private static readonly Regex regex = new Regex("[^a-zA-Z0-9]");
        //O(n) time complexity and O() space complexity
        public static bool isPalindrom(string thePhrase)
        {
            string newPhrase = regex.Replace(thePhrase, "").ToLower();
            string reversePhrase = "";
            for(int i = newPhrase.Length - 1; i >= 0; i--)
            {
                reversePhrase += newPhrase[i];

            }
            return newPhrase == reversePhrase;
        }
        //O(n) time complexity and O(n) space complexity
        public static bool isMPalindrom(string thePhrase, int idx = 0)
        {
            string newPhrase = regex.Replace(thePhrase, "").ToLower();
            int len = newPhrase.Length - 1 - idx;
            return idx >= len ? true : newPhrase[idx] == newPhrase[len] && isMPalindrom(newPhrase, ++idx);
        }
        //O(n) time complexity and O(1) space complexity 
        public static bool isPPalindrom(string thePharse)
        {
            string newPhrase = regex.Replace(thePharse, "").ToLower();
            int leftIndices = 0;
            int rightIndices = newPhrase.Length - 1;
            
            while (leftIndices < rightIndices)
            {
                if(newPhrase[leftIndices] != newPhrase[rightIndices])
                    return false;
                leftIndices++;
                rightIndices--;
            }
            return true;
        }
    }
}