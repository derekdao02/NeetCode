class Solution
{
    private int[] nums;
    private int target;

    public Solution(int[] nums, int target)
    {
        this.nums = nums;
        this.target = target;

    }

    public int[] TwoSum()
    {
        var map = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            var remainNum = target - nums[i];

            // Check if the anothernumber already exists in the dictionary
            if (map.ContainsKey(remainNum))
            {
                return new int[] { map[remainNum], i };
            }

            // Add the current number and its index to the dictionary
            // The key is the number, the value is its index
            if (!map.ContainsKey(nums[i]))
            {
                map.Add(nums[i], i);
            }
        }
        return Array.Empty<int>();
    }

    public int[] TwoSum_1()
    {
        var map = new Dictionary<int, int>();
        map[nums[0]] = 0;

        for (int i = 1; i < nums.Length; i++)
        {
            var anotherNum = target - nums[i];

            // Check if the anothernumber already exists in the dictionary
            if (map.TryGetValue(anotherNum, out int previous))
            {
                return new int[] { previous, i };
            }

            // Add the current number and its index to the dictionary
            // The key is the number, the value is its index
            map[nums[i]] = i;
        }
        return Array.Empty<int>();
    }
}
