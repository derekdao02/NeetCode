class Solution
{
    public Solution() { }

    // X ^ 0 = X: Bất kỳ số nào XOR với 0 cũng bằng chính nó.
    // X ^ X = 0: Bất kỳ số nào XOR với chính nó cũng bằng 0
    public int SingalNumber(int[] nums)
    {
        int rs = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            rs ^= nums[i];
        }

        return rs;
    }
}
