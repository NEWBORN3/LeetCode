using System.Security.AccessControl;
using System;
namespace LeetCode
{
    public static class MedianOfTwoSortedArrays
    {
        public static double median(int[] nums1, int[] nums2)
        {
            int lenFirst = nums1.Length;//nums1 
            int lenSecond = nums2.Length;//nums2 
            if (lenFirst > lenSecond)
                return median(nums2,nums1);

            int l = 0;
            int r = lenFirst;
            int mergHalf = (lenFirst + lenSecond + 1) / 2;
            
            while (l <= r)
            {
                
                int leftASize = (l + r) / 2;
                int leftBSize =   mergHalf - leftASize; 
                
                int leftA = leftASize > 0 ? nums1[leftASize - 1] : Int32.MinValue ;
                int rightA = leftASize < lenFirst ? nums1[leftASize] : Int32.MaxValue;
                int leftB = leftBSize > 0 ? nums2[leftBSize - 1] : Int32.MinValue;
                int rightB = leftBSize < lenSecond ? nums2[leftBSize] : Int32.MaxValue;

                //partition correct 
                if (leftA <= rightB && leftB <= rightA)
                {
                    //odd
                    if ((lenFirst + lenSecond)  % 2 != 0)
                    {
                        return Math.Max(leftA, leftB);
                    }
                    //even 
                    else 
                    {
                        return (Math.Max(leftA, leftB) + Math.Min(rightA,rightB)) / 2.0;
                    }
                } 
                else if (leftA > rightB)
                {
                    r = leftASize - 1;
                } 
                else {
                    l = leftASize + 1; 
                }   
            }
         return 0;
        }
    }
}