internal class Program
{
    private static void Main(string[] args)
    {
        Solution solution = new Solution();

        var list1 = solution.MakeList(new int[] { 1, 2, 3 });
        var list2 = solution.MakeList(new int[] { 1, 3, 4, 5 });

        var results = solution.MergeTwoLists(list1, list2);

        while (results != null)
        {
            Console.WriteLine(results.val);
            results = results.next;
        }
    }
}
