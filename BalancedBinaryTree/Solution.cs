class Solution
{
    public Solution() { }

    public bool IsBalanced(TreeNode root)
    {
        return Height(root) != -1;
    }

    private int Height(TreeNode node)
    {
        if (node == null) return 0;

        var leftNode = Height(node.left);
        if (leftNode == -1) return -1;

        var rightNode = Height(node.right);
        if (rightNode == -1) return -1;

        if (Math.Abs(leftNode - rightNode) > 1) return -1;

        return Math.Max(leftNode, rightNode) + 1;
    }
}
