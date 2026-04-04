class Solution
{
    public Solution() { }

    public bool CanConstruct(string ransomNote, string magazine)
    {
        // 26 is total charactor in alphabet
        int[] count = new int[26];

        for (int i = 0; i < magazine.Length; i++)
        {
            // - 'a' means get position character in array and then add 1 unit
            count[magazine[i] - 'a']++;
        }

        for (int i = 0; i < ransomNote.Length; i++)
        {
            var pos = ransomNote[i] - 'a';
            if (count[pos] > 0)
            {
                count[pos] -= 1;
                continue;
            }
            return false;
        }

        return true;
    }
}
