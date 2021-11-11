using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
           string theWord = "clementisacap";
           int[] fArray = {1,3};
           int[] sArray = {2};
           double res = MedianOfTwoSortedArrays.median(fArray,sArray);
           Console.WriteLine(String.Join(',', res));
        }
    }
}