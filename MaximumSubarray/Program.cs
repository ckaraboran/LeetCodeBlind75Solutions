// Given an integer array nums, find the subarray which has the largest sum and return its sum.


using MaximumSubarray;

var innerCalculators = new List<IMaximumSubarrayFinder>();
innerCalculators.Add(new OnePass());

Calculate(new[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }, innerCalculators);
Calculate(new[] { 1, -2, 4, 3, -1, 5, 3 }, innerCalculators);

void Calculate(int[] values, List<IMaximumSubarrayFinder> calculators)
{
    foreach (var calculator in calculators)
    {
        var result = calculator.MaxSubArray(values);
        Console.WriteLine($"{calculator.ToString()}: {result}");
    }
}