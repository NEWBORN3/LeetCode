using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] theArray = new int[] {3,5,-4,8,11,1,-1,6};
            int theTrget = 10;

            int[] newArray = TwoSums.twoSumSorted(theArray,theTrget);

            foreach (var item in newArray)
            {
                
                Console.WriteLine(item);
            }
        }
    }
}