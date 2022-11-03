using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1.Two_Sum;
using static _1.Two_Sum.Program;

namespace testing
{
    [TestClass]
    public class LeepCodeTests
    {
        /// <summary>
        /// Runtime: 309 ms	
        /// Memory : 42.5 MB	
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        [TestMethod]
        [DataRow(new int[] { 2, 7, 11, 15 }, 9)]
        [DataRow(new int[] { 3, 2, 4}, 6)]
        public void TwoSum_Ok(int[] nums, int target)
        {
            int[] indexes = new Solution().TwoSum(nums, target);
            int result = nums[indexes[0]] + nums[indexes[1]];
            Assert.AreEqual(target, result);
        }
        /// <summary>
        /// Runtime: 364 ms	
        /// Memory : 43.7 MB	
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        [TestMethod]
        [DataRow(new int[] { 2, 7, 11, 15 }, 9)]
        [DataRow(new int[] { 3, 2, 4 }, 6)]
        public void TwoSum_ArrayFunction_Ok(int[] nums, int target)
        {
            int[] indexes = new Solution().TwoSum_WithArrayFunction(nums, target);
            int result = nums[indexes[0]] + nums[indexes[1]];
            Assert.AreEqual(target, result);
        }

        /// <summary>
        /// Runtime: 259 ms	
        /// Memory : 42.7 MB	
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        [TestMethod]
        [DataRow(new int[] { 2, 7, 11, 15 }, 9)]
        [DataRow(new int[] { 3, 2, 4 }, 6)]
        public void TwoSum_Dictionary_Ok(int[] nums, int target)
        {
            int[] indexes = new Solution().TwoSum_WithDictionary(nums, target);
            int result = nums[indexes[0]] + nums[indexes[1]];
            Assert.AreEqual(target, result);
        }

        /// <summary>
        /// Runtime: 228 ms	
        /// Memory : 42.6 MB	
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        [TestMethod]
        [DataRow(new int[] { 2, 7, 11, 15 }, 9)]
        [DataRow(new int[] { 3, 2, 4 }, 6)]
        public void TwoSum_Dictionary_Opt_Ok(int[] nums, int target)
        {
            int[] indexes = new Solution().TwoSum_WithDictionary_Optimized(nums, target);
            int result = nums[indexes[0]] + nums[indexes[1]];
            Assert.AreEqual(target, result);
        }
    }
}
