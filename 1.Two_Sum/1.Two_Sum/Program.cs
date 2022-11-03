using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Intrinsics.X86;

namespace _1.Two_Sum
{
    /// <summary>
    /// https://leetcode.com/problems/two-sum/
    /// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
    /// You may assume that each input would have exactly one solution, and you may not use the same element twice.
    /// You can return the answer in any order.
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
        }
        public class Solution
        {
            public int[] TwoSum(int[] nums, int target)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    for (int j = i+1; j <= nums.Length-1; j++)
                    {
                        if (nums[i] + nums[j] == target)
                        {
                            
                            return new int[2] { i,j};
                        }
                    }
                }
                return default;
            }

            /// <summary>
            /// From :https://zyrastory.com/en/coding-en/leetcode-en/leetcode-1-two-sum-solution-and-explanation-en/#C_Solution
            /// </summary>
            /// <param name="nums"></param>
            /// <param name="target"></param>
            /// <returns></returns>
            public int[] TwoSum_WithArrayFunction(int[] nums, int target)
            {
                int max = nums.Length;                  //the length of the array
                int index;

                for (int i = 0; i < max; i++)                //find from the first element
                {
                    //the difference of the array element with the target number
                    int diff = target - nums[i];
                    index = Array.FindIndex(nums, i + 1, x => x == diff);

                    //if the diff number index have found
                    if (index != -1)
                    {
                        return new int[2] { i, index };
                    }
                }
                return new int[2] { 0, 0 };
            }

            /// <summary>
            /// From :https://zyrastory.com/en/coding-en/leetcode-en/leetcode-1-two-sum-solution-and-explanation-en/#C_Solution
            /// </summary>
            /// <param name="nums"></param>
            /// <param name="target"></param>
            /// <returns></returns>
            public int[] TwoSum_WithDictionary(int[] nums, int target)
            {
                Dictionary<int, int> dict = new Dictionary<int, int>();
                for (int i = 0; i < nums.Length; i++)
                {
                    int diff = target - nums[i];
                    if (dict.ContainsKey(diff))
                    {
                        return new int[] { dict[diff], i };
                    }
                    if (!dict.ContainsKey(nums[i]))
                    {
                        dict.Add(nums[i], i);
                    }
                }
                return new int[] { 0, 0 };
            }

            /// <summary>
            /// https://leetcode.com/problems/two-sum/discuss/1676476/C-Fastest-O(n)-Solution
            /// </summary>
            /// <param name="nums"></param>
            /// <param name="target"></param>
            /// <returns></returns>
            public int[] TwoSum_WithDictionary_Optimized(int[] nums, int target)
            {
                var seen = new Dictionary<int, int>();

                for (var i = 0; i < nums.Length; i++)
                {
                    if (seen.TryGetValue(target - nums[i], out var index))
                    {
                        return new[] { index, i };
                    }

                    seen.TryAdd(nums[i], i);
                }

                return null;
            }
        }
    }
}
