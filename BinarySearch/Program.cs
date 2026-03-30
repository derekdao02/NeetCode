// See https://aka.ms/new-console-template for more information

internal class Program
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        var nums = new int[] { -1, 0, 3, 5, 9, 12 };
        Console.WriteLine($"Index: {solution.Search(nums, 9)}");
    }
}
