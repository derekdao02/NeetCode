namespace DefaultNamespace;

public class Solution
{
    public Solution() { }

    public bool IsAnagram(string s, string t)
    {
        if(s.Length != t.Length) return false;

        var arrS = s.ToCharArray();
        var arrT = t.ToCharArray();
        Array.Sort(arrS);
        Array.Sort(arrT);
        for (int i = 0; i < arrS.Length; i++)
        {
            if (arrS[i] != arrT[i]) return false;
        }

        return true;
    }
    
    public bool IsAnagram_1(string s, string t)
    {
        if(s.Length != t.Length) return false;

        // 26 is total charactor in alphabet
        char[] count = new char[26];

        for (int i = 0; i < s.Length; i++) {
            // - 'a' means get position character in array and then add 1 unit
            count[s[i] - 'a']++;
            count[t[i] - 'a']--;
        }

        // after that, check in array, if it has any position have value different from 0, return fail 
        foreach (var c in count) {
            if (c != 0) return false;
        }
        
        return true;
    }
}

