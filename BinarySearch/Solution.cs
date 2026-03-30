class Solution
{
    public Solution() { }

    public int Search(int[] nums, int target)
    {
        var splitIndice = nums.Length/2;

        if(target == nums[splitIndice]) return splitIndice;

        int i = target > nums[splitIndice] ? splitIndice : 0;
        for (; i< nums.Length; i++)
            if (nums[i] == target) return i;

        return -1;
    }
}
