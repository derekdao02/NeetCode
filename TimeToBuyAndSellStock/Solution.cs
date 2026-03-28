class Solution
{
    public Solution() { }

    public int MaxProfit(int[] prices)
    {
        var minValue = prices[0];
        var maxProfit = 0;

        for (int i = 1; i < prices.Length; i++)
        {
            minValue = prices[i] < minValue ? prices[i] : minValue;
            if (prices[i] > minValue)
            {
                var sellPrice = prices[i] - minValue;
                if (sellPrice > maxProfit) maxProfit = sellPrice;
            }
        }

        return maxProfit;
    }
}
