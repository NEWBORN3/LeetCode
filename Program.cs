using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] num3 = {0,1,2,2,3,0,4,2};
            int val = 2;
            int un = TheArray.RemoveElement(num3,val);
            Console.WriteLine("o- {0}",un);        
        }
    }
}