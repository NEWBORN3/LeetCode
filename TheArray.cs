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

        /*
            Given a fixed length array arr of integers, duplicate each occurrence of zero, shifting the remaining elements to the right.
            
            Input: [1,0,2,3,0,4,5,0]
            Output: null
            Explanation: After calling your function, the input array is modified to: [1,0,0,2,3,0,0,4]
        */
        public static void DuplicateZeros(int[] arr) 
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == 0 )
                {
                    for(int j = arr.Length - 1; j > i; j--)
                    {
                        arr[j] = arr[j-1];
                    }
                    i++;
                }
            }
        }

        /* 
            You are given two integer arrays nums1 and nums2, sorted in non-decreasing order, 
            and two integers m and n, representing the number of elements in nums1 and nums2 respectively.
        
            Input: nums1 = [1,2,3,0,0,0], m = 3, nums2 = [2,5,6], n = 3
            Output: [1,2,2,3,5,6]
            Explanation: The arrays we are merging are [1,2,3] and [2,5,6].
            The result of the merge is [1,2,2,3,5,6] with the underlined elements coming from nums1.
        */

        public static void Merge(int[] nums1, int m, int[] nums2, int n) {
            for (int i = m,j=0; i < nums1.Length; i++)
            {
                nums1[i] = nums2[j];
                j++;                
            }
            Array.Sort(nums1);
        }
    

        /*
            Given an integer array nums and an integer val, 
            remove all occurrences of val in nums in-place. The relative order of the elements may be changed.

            Input: nums = [3,2,2,3], val = 3
            Output: 2, nums = [2,2,_,_]
            Explanation: Your function should return k = 2, with the first two elements of nums being 2.It does not matter what you leave beyond the returned k (hence they are underscores).
        */

        
        public static int RemoveElement(int[] nums, int val) {
            int length = nums.Length;
            for (int i = 0; i < length; i++)
            {
                if(nums[i] == val)
                {
                    for (int j = i +1 ; j < length; j++)
                    {   
                        nums[j - 1] = nums[j];
                    }
                    i--;
                    length--;
                }
            }
            return length;        
        }
    }
}