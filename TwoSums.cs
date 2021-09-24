using System;
using System.Collections;
namespace LeetCode
{
    public static class TwoSums
    {
        //O(1) space and O(n^2) time complexity 
        public static int[] twoSums(int[] nums, int targetSum)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                int firstNum = nums[i];
                for (int j = i+1; j < nums.Length; j++)
                {
                    int secondNum = nums[j];
                    if(firstNum + secondNum == targetSum)
                        return new int[] {firstNum,secondNum};
                }
            }
            return null;
        }

        //Using an hash table O(n) time and space complexity. 
        public static int[] twoSumHash(int[] nums, int targetSum)
        {
            Hashtable ht = new Hashtable();

            foreach (int item in nums)
            {
                if (ht.Contains(targetSum - item))
                {

                    return new int[] {targetSum - item, item};
                }
                else 
                {
                    ht[item] = true;
                }
            }
            return new int[]{};
        }

        //O(nLog(n)) time complexity and O(1) time
        public static int[] twoSumSorted(int[] nums, int targetSum)
        {
            Array.Sort(nums);
            int left = 0;
            int right = nums.Length - 1;
            
            while (left < right)
            {
                int currentSum = nums[left] + nums[right];
                if (currentSum == targetSum)
                {
                    return new int[] {nums[left], nums[right]};
                } else if(currentSum < targetSum)
                {
                    left++;
                } else {
                    right--;
                }
            }
            return new int[]{};
        }

    }
}