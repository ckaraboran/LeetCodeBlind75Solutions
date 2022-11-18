// See https://aka.ms/new-console-template for more information

using BestTimeToBuyAndSellStock;

Calculate(new Bruteforce());
Calculate(new OnePass());

void Calculate(IStockBuyer calculator)
{
    var values = new [] { 6, 2, 8, 1, 7 };
    var result = calculator.MaxProfit(values);
    Console.WriteLine(result);
}