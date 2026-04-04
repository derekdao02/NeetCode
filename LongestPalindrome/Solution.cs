public class Solution {
    public int LongestPalindrome(string s) {
        Span<int> buckets = stackalloc int[128];
        
        foreach (char c in s) {
            buckets[c]++;
        }

        bool hasOdd = false;
        int result = 0;
        foreach (int i in buckets) {
            if (i % 2 == 0) {
                result += i;
                continue;
            }

            if (!hasOdd) {
                hasOdd = true;
                result++;
            }

            result += i - 1;
        }

        return result;
    }
}
