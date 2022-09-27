using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 7, 11, 15 };
            int target = 9;
            var results = new Solution().TwoSum(array,target);

            for (int i = 0; i < results.Length; i++)
            {
                Console.WriteLine(i);
            }
           
        }
    }
}
