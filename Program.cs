using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            /* TwoSums
            int[] array = { 2, 7, 11, 15 };
            int target = 9;
            var results = new Solution().TwoSum(array,target);

            for (int i = 0; i < results.Length; i++)
            {
                Console.WriteLine(i);
            }*/
        //l1 = [2,4,3], l2 = [5,6,4]
         ListNode l1 = new ListNode(2,new ListNode(4,new ListNode(3)));
         ListNode l2 = new ListNode(5,new ListNode(6,new ListNode(4)));

            ListNode result = new AddTwoNumbersSolution().AddTwoNumbers(l1,l2);
                       
        }
    }
}
