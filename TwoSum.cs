﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var dic = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(nums[i]))
                {
                    return new int[] { dic[nums[i]], i };
                }
                else
                    dic[target - nums[i]] = i;
            }

            return new int[] { };
        }
    }
}
