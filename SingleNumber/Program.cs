internal class Program
{
    private static void Main(string[] args)
    {
        Solution solution = new Solution();

        var nums = new int[] {1,1,2,3,2};
        Console.WriteLine(solution.SingalNumber(nums));
    }
}
