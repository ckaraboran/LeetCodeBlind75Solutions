/*
You are given an array prices where prices[i] is the price of a given stock on the ith day.
You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.
Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0.
 */

using BestTimeToBuyAndSellStock;

Calculate(new Bruteforce());
Calculate(new OnePass());

void Calculate(IStockBuyer calculator)
{
    var values = new [] { 6, 2, 8, 1, 7 };
    var result = calculator.MaxProfit(values);
    Console.WriteLine(result);
}