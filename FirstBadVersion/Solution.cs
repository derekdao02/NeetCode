class Solution
{
    public Solution() { }

    public int FirstBadVersion(int n)
    {
        if (n == 1) return n;
        int l = 1, r = n;
        while (l < r)
        {
            var m = l + (r - l) / 2;
            if (IsBadVersion(m))
            {
                r = m;
                continue;
            }

            l = m + 1;
        }
        return l;
    }

    private bool IsBadVersion(int version)
    {
        if (version == 4)
        {
            return true;
        }

        return false;
    }
}
