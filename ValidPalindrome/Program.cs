internal class Program
{
    private static void Main(string[] args)
    {
        Solution solution = new Solution();
        var str = "A man, a plan, a canal: Panama";
        Console.WriteLine(solution.IsPalindrome_1(str));
    }
}
