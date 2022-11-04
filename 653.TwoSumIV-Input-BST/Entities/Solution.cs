using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Solution
    {
        HashSet<int> seen = new();
        public bool FindTarget(TreeNode root, int k)
        {
            List<int> flatted = root.Flat(root).ToList();
            var seen = new Dictionary<int, int>();
            for (var i = 0; i < flatted.Count; i++)
            {
                if (seen.TryGetValue(k - flatted[i], out var index))
                {
                    return true;
                }

                seen.TryAdd(flatted[i], i);
            }

            return false;
        }

        public bool FindTarget_HashSet(TreeNode root, int k)
        {
            if (root is null) return false;
            if (seen.Contains(k - root.val)) return true;
            seen.Add(root.val);
            return FindTarget_HashSet(root.left, k) || FindTarget_HashSet(root.right, k);
        }
    }
}
