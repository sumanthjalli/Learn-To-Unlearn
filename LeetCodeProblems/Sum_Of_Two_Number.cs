using System;
using System.Collections.Generic;

namespace LeetCodeProblems
{
    public static class Sum_Of_Two_Number
    {
        public static int[] SumOfTwoNumbers(int[] nums, int target)
        {
            int[] result = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        result[0] = i;
                        result[1] = j;
                    }
                }
            }
            return result;
        }
        //Optimized solution
        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> visitedNumbers = new Dictionary<int, int>();
            int[] result = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                int delta = target - nums[i];
                if (visitedNumbers.TryGetValue(delta, out int index))
                {
                    return new[] { index, i };
                }
                if (!visitedNumbers.ContainsKey(nums[i]))
                {
                    visitedNumbers.Add(nums[i], i);
                }
            }
            return result;
        }
    }
}
