internal class Program
{
    private static void Main(string[] args)
    {
        int[] nums = new int[] { 1, 2, 3, 4, 5, 6, 7 };
        int target = 9;
        Solution solution = new Solution(nums, target);
        var result = solution.TwoSum();
        foreach (var item in result)
        {

            Console.WriteLine(item + " ");
        }
    }
}
