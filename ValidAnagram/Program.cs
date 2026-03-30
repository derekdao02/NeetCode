// See https://aka.ms/new-console-template for more information

using DefaultNamespace;

internal class Program
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        Console.WriteLine(solution.IsAnagram_1("anagram", "nagaram"));
        Console.WriteLine(solution.IsAnagram_1("ggii", "eekk"));
        Console.WriteLine(solution.IsAnagram_1("rat", "car"));
    }
}
