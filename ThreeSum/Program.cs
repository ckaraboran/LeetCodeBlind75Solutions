/*
 * Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]]
 * such that i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.
 * Notice that the solution set must not contain duplicate triplets.
 *
 * Example:
 * Input: nums = [-1,0,1,2,-1,-4]
 * Output: [[-1,-1,2],[-1,0,1]]
 * Explanation:
 * nums[0] + nums[1] + nums[2] = (-1) + 0 + 1 = 0.
 * nums[1] + nums[2] + nums[4] = 0 + 1 + (-1) = 0.
 * nums[0] + nums[3] + nums[4] = (-1) + 2 + (-1) = 0.
 * The distinct triplets are [-1,0,1] and [-1,-1,2].
 * Notice that the order of the output and the order of the triplets does not matter.
 */

using ThreeSum;

var innerCalculators = new List<IThreeSumFinder>();
innerCalculators.Add(new TwoPointers());
innerCalculators.Add(new BinarySearch());

Calculate(new[] { -1, 0, 1, 2, -1, -4 }, innerCalculators);
Calculate(new[] { 0, 1, 1 }, innerCalculators);
Calculate(new[] { 0, 0, 0 }, innerCalculators);


void Calculate(int[] values, List<IThreeSumFinder> calculators)
{
    foreach (var calculator in calculators)
    {
        var result = calculator.ThreeSum(values);
        Console.WriteLine(calculator);
        foreach (var list in result) Console.WriteLine($"{string.Join(", ", list)}");
    }
}