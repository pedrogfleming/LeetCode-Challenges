namespace Entities
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        private IEnumerable<int> flatted;        
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
            flatted = new int[0];
        }
        public IEnumerable<int> Flat(TreeNode t)
        {
            flatted = flatted.Append(t.val);
            if(t.left is not null)
            {
                Flat(t.left);
            }
            if(t.right is not null)
            {
                Flat(t.right);
            }
            return flatted;
        }
    }
}