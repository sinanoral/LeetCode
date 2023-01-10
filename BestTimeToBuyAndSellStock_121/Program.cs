namespace BestTimeToBuyAndSellStock_121;

internal static class Program
{
    public static void Main()
    {
        int[] prices = { 7, 1, 5, 3, 6, 4 };
        var ret = MaxProfit(prices);
        
        int[] prices2 = { 7, 6, 4, 3, 1 };
        var ret2 = MaxProfit(prices);
    }
    
    private static int MaxProfit(int[] prices) {
        int min = prices[0];
        int maxProfit = 0;

        for(int i = 1; i < prices.Length; i++)
        {
            min = Math.Min(min, prices[i]);
            maxProfit = Math.Max(maxProfit, prices[i] - min);
        }

        return maxProfit;
    }
}