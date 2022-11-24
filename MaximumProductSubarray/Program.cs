/* Given an integer array nums, find a subarray that has the largest product, and return the product.
 The test cases are generated so that the answer will fit in a 32-bit integer.
 */

using MaximumProductSubarray;

var innerCalculators = new List<IMaximumProductSubarrayFinder>();
innerCalculators.Add(new OnePass());

Calculate(new[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }, innerCalculators);
Calculate(new[] { 1, -2, 4, 3, -1, 5, 3 }, innerCalculators);
Calculate(new[] { 2, 3, -2, 4 }, innerCalculators);
Calculate(new[] { -2, 0, -1 }, innerCalculators);


void Calculate(int[] values, List<IMaximumProductSubarrayFinder> calculators)
{
    foreach (var calculator in calculators)
    {
        var result = calculator.MaxProduct(values);
        Console.WriteLine($"{calculator.ToString()}: {result}");
    }
}