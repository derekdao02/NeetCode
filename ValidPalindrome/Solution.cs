class Solution
{
    public Solution() { }

    public bool IsPalindrome(string s)
    {
        var mergeString = "";
        foreach (char c in s)
            if (char.IsLetterOrDigit(c)) mergeString += char.ToLower(c);

        var l = 0;
        var r = mergeString.Length - 1;
        while (l < r)
            if (mergeString[l++] != mergeString[r--]) return false;

        return true;
    }

    public bool IsPalindrome_1(string s)
    {
        var first = 0;
        var last = s.Length - 1;

        while (first < last)
        {
            if (!isValidCharacter(s[first]))
            {
                first++;
                continue;
            }

            if (!isValidCharacter(s[last]))
            {
                last--;
                continue;
            }

            if (char.ToLower(s[first]) != char.ToLower(s[last]))
                return false;

            first++;
            last--;
        }

        return true;
    }

    private bool isValidCharacter(char c)
    {
        int ascivalue = (int)c;
        if (ascivalue >= 97 && ascivalue <= 122 || ascivalue >= 65 && ascivalue <= 90 || ascivalue >= 48 && ascivalue <= 57)
        {
            return true;
        }
        return false;
    }
}
