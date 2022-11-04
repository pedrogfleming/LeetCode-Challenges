using Entities;

namespace _167.TwoSumII_Input_Array_Is_Sorted
{
    /// <summary>
    /// https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/
    /// </summary>
    [TestClass]
    public class LeetCodeTests
    {
        [TestMethod]
        [DataRow(new int[] {2, 7, 11, 15}, 9)]
        [DataRow(new int[] {2, 3, 4 }, 6)]
        [DataRow(new int[] {-1, 0 }, -1)]
        public void TwoSum_Ok(int[] nums, int target)
        {
          var result = new Solution().TwoSum(nums, target);
          int checkingResult = (target - nums[result[0]] - nums[result[1]]);
          Assert.IsTrue(checkingResult == 0);
        }
    }
}