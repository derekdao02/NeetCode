internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    private static TreeNode BuildTree(int[] nodes)
    {
        TreeNode root = new TreeNode(nodes[0]);

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        int i = 1;
        while (i < nodes.Length && queue.Count > 0)
        {
            // Lấy Node cha ra để tìm con cho nó
            TreeNode parent = queue.Dequeue();

            // Tìm con bên trái
            if (i < nodes.Length && nodes[i] != null)
            {
                parent.left = new TreeNode(nodes[i]);
                queue.Enqueue(parent.left);
            }
            i++;

            // Tìm con bên phải
            if (i < nodes.Length && nodes[i] != null)
            {
                parent.right = new TreeNode(nodes[i]);
                queue.Enqueue(parent.right);
            }
            i++;
        }

        return root;
    }
}
