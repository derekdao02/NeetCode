class Solution
{
    public Solution() { }

    public bool IsValid(string s)
    {
        Stack<char> stack = new();
        Dictionary<char, char> map = new() {
            {'(', ')'},
            {'{', '}'},
            {'[', ']'}
        };

        for (int i = 0; i < s.Length; i++)
        {
            if (map.ContainsKey(s[i]))
            {
                stack.Push(s[i]);
            }
            else if (stack.Count() > 0 && s[i] == map[stack.Peek()])
            {
                stack.Pop();
            }
            else
            {
                return false;
            }
        }

        return stack.Count() == 0;
    }

    public bool IsValid_1(string s)
    {
        int n = s.Length;
        // Optimization: Odd length strings can never be valid
        if (n % 2 != 0) return false;

        Stack<char> stack = new();

        foreach (char c in s)
        {
            if (c == '(') stack.Push(')');
            else if (c == '{') stack.Push('}');
            else if (c == '[') stack.Push(']');

            else if (stack.Count == 0 || stack.Pop() != c)
            {
                return false;
            }
        }

        return stack.Count == 0;
    }

}
