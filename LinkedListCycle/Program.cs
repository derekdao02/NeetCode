internal class Program
{
    private static void Main(string[] args)
    {
        Solution solution = new Solution();
        var node = CreateLinkedListCycle(new int[] { 1,2 }, -1);
        // var node = CreateLinkedList(new int[] { 3, 2, 0, -4 });
        var result = solution.HasCycle(node);
        Console.WriteLine("Hello, World!");
    }

    private static ListNode CreateLinkedListCycle(int[] nums, int pos)
    {
        if (nums == null || nums.Length == 0) return null;

        ListNode head = new ListNode(nums[0]);
        ListNode current = head;
        ListNode cycleTargetNode = null;

        if (pos == 0) cycleTargetNode = head;

        for (int i = 1; i < nums.Length; i++)
        {
            current.next = new ListNode(nums[i]);
            current = current.next;

            if (i == pos)
            {
                cycleTargetNode = current;
            }
        }

        if (pos != -1 && cycleTargetNode != null)
        {
            current.next = cycleTargetNode;
        }

        return head;
    }

    private static ListNode CreateLinkedList(int[] nums)
    {
        var node = new ListNode(nums[0]);

        for (int i = 1; i < nums.Length; i++)
        {
            node.next = new ListNode(nums[i]);

        }

        return node;
    }
}
