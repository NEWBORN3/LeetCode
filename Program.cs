using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] nums = {1,0,2,3,0,4,5,0};
            TheArray.DuplicateZeros(nums);
            Console.WriteLine("o- {0}",String.Join(",",nums));        
        }
    }
}
