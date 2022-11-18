/*
 * It's very easy because it does not ask for the place of the values. It only asks the max difference.
 * Complexity Analysis:
 * Time complexity: O(n)
 * Space complexity O(1)
 */

namespace BestTimeToBuyAndSellStock;

public class OnePass : IStockBuyer
{
    public int MaxProfit(int[] prices)
    {
        int minprice = Int32.MaxValue;
        int maxprofit = 0;
        for (int i = 0; i < prices.Length; i++)
        {
            if (prices[i] < minprice)
                minprice = prices[i];
            else if (prices[i] - minprice > maxprofit)
                maxprofit = prices[i] - minprice;
        }

        return maxprofit;
    }
}