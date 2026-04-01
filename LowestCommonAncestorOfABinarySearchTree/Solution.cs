class Solution
{
    public Solution() { }

    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        TreeNode current = root;

        while (true)
        {
            if (p.val < current.val && q.val < current.val)
            {
                current = current.left;
                continue;
            }
            if (p.val > current.val && q.val > current.val)
            {
                current = current.right;
                continue;
            }
            break;
        }

        return current;
    }
}
