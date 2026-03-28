class Solution
{
    public Solution() { }

    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode listNode = new ListNode(0);
        ListNode op = listNode;


        while (list1 != null && list2 != null)
        {

            if (list1.val < list2.val)
            {
                op.next = list1;
                list1 = list1.next;
            }
            else
            {
                op.next = list2;
                list2 = list2.next;
            }

            op = op.next;
        }

        op.next = list1 ?? list2;

        return listNode.next;
    }

        public ListNode MakeList(int[] nums)
    {
        ListNode listNode = new ListNode(0);
        ListNode op = listNode;

        foreach (var val in nums)
        {
            op.next = new ListNode(val);
            op = op.next;
        }

        return listNode.next;
    }
}
