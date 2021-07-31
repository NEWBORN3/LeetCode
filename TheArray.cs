using System;
namespace LeetCode
{
    public static class TheArray
    {
        /*
            Given a binary array nums, return the maximum number of consecutive 1's in the array.

            Input: nums = [1,0,1,1,0,1]
            Output: 2
        */
        public static int FindMaxConsecutiveOnes(int[] nums)
        {
            int maxCount = 0;
            int tempCount = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                if(nums[i] == 1)
                {
                    tempCount++;
                    maxCount = Math.Max(maxCount,tempCount);
                } else {
                    tempCount = 0;
                }

            }
            return maxCount;
        }

        /* 
            Given an array nums of integers, return how many of them contain an even number of digits.

            Input: nums = [555,901,482,1771]
            Output: 1 
        */ 

        public static int FindNumbers(int[] nums) {
            int count = 0;
            foreach(int num in nums)
            {
                if(CountDigit(num) % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }
        private static int CountDigit(int num)
        {
            int count = 0;
            while(num != 0)
            {
                num = num/10;
                count++;
            }
            return count;
        }

        /* 
            Squares of a Sorted Array
            
            Input: nums = [-4,-1,0,3,10]
            Output: [0,1,9,16,100]
        */

        public static int[] SortedSquares(int[] nums) {
            int[] SequredNums = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                SequredNums[i] = nums[i] * nums[i];
            }
            Array.Sort(SequredNums);
            return SequredNums;
        }


    }
}