/*
Complexity Analysis:
Time complexity: O(n)
Space complexity O(n)
 */

namespace TwoSum;

public class OnePassHash : ITwoSumCalculator
{
    public int[] TwoSum(int[] nums, int target)
    {
        var map = new Dictionary<int, int>();
        for (var i = 0; i < nums.Length; i++)
        {
            var complement = target - nums[i];
            if (map.ContainsKey(complement)) return new[] { map[complement], i };
            map.Add(nums[i], i);
        }

        // In case there is no solution, we'll just return null
        return Array.Empty<int>();
    }
}