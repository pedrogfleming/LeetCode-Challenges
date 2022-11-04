using Entities;

namespace _653.TwoSumIV_Input_BST
{
    [TestClass]
    public class LeetCodeTests
    {
        TreeNode treeNodeCase;
        public LeetCodeTests()
        {
            treeNodeCase = new(val: 5,
                    left: new TreeNode(val: 3,left: new TreeNode(2),right: new TreeNode(4)),
                    right: new TreeNode(val: 6,left: null, right: new TreeNode(7)));
        }

        [TestMethod]
        public void FlattedTreeNode_Ok()
        {
            List<int> flatted = treeNodeCase.Flat(treeNodeCase).ToList();
            Assert.IsTrue(flatted.SequenceEqual(new List<int>() { 5, 3, 2, 4, 6, 7 }));
        }

        [TestMethod]
        [DataRow(9)]
        public void FindTarget_9_Found_Ok(int k)
        {
           bool result = new Solution().FindTarget(treeNodeCase, k);
           Assert.IsTrue(result);
        }
        [TestMethod]
        [DataRow(28)]
        public void FindTarget_28_NotFound_Ok(int k)
        {
            bool result = new Solution().FindTarget(treeNodeCase, k);
            Assert.IsFalse(result);
        }
        [TestMethod]
        [DataRow(9)]
        public void FindTargetHashSet_9_Found_Ok(int k)
        {
            bool result = new Solution().FindTarget_HashSet(treeNodeCase, k);
            Assert.IsTrue(result);
        }
        [TestMethod]
        [DataRow(28)]
        public void FindTargetHashSet_28_NotFound_Ok(int k)
        {
            bool result = new Solution().FindTarget_HashSet(treeNodeCase, k);
            Assert.IsFalse(result);
        }
    }
}