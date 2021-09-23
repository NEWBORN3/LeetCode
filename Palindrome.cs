using System;
namespace LeetCode
{
    public static class Palindrome
    {
        //O(n) time complexity and O(1) space complexity 
        public static Boolean isPalindrome(string theWord)
        {
            int leftIdx = 0;
            int rightIdx = theWord.Length - 1;
            
            while (leftIdx < rightIdx)
            {
                if (theWord[leftIdx] != theWord[rightIdx])
                    return false;
                leftIdx++;
                rightIdx--;
            }
            return true;
        }

        //O(n) time complexity and O(n) space complexity 
        public static Boolean checkPalindrome(string theWord, int idx = 0)
        {
            int len = theWord.Length - 1 - idx;

            return idx >= len ? true : theWord[idx] == theWord[len] && checkPalindrome(theWord,++idx);
        }

        //O(n) time complexity and O(n^2) space complexity 
        public static Boolean palindromeCheck(string theWord) 
        {
            string reversed = "";
            for (int i = theWord.Length - 1; i >= 0 ; i--)
            {
                reversed += theWord[i]; 
            }
            return theWord == reversed;
        }
        
    }
}