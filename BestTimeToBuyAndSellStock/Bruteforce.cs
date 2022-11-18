/*
 * Complexity Analysis:
 * Time complexity: O(n2)
 * Space complexity O(1)
 */

namespace BestTimeToBuyAndSellStock;

public class Bruteforce : IStockBuyer
{
    public int MaxProfit(int[] prices)
    {
        int maxprofit = 0;
        for (int i = 0; i < prices.Length - 1; i++)
        {
            for (int j = i + 1; j < prices.Length; j++)
            {
                int profit = prices[j] - prices[i];
                if (profit > maxprofit)
                    maxprofit = profit;
            }
        }
        return maxprofit;
    }
}