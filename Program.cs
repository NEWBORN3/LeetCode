using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int theNumber = 5768;
            Console.WriteLine(theNumber%10);
            int a = theNumber%10;
            int n = theNumber/10;
            while(n != 0)  
            {
                Console.WriteLine(a);
                a = n % 10;
                n = n /10;
            }
        }
    }
}