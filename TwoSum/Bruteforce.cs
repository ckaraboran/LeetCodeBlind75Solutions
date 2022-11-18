/*
Complexity Analysis:
Time complexity: O(n2)
Space complexity O(1)
 */

namespace TwoSum;

public class Bruteforce : ITwoSumCalculator
{
    public int[] TwoSum(int[] nums, int target)
    {
        for (var i = 0; i < nums.Length; i++)
        {
            for (var j = i + 1; j < nums.Length; j++)
            {
                if (nums[j] == target - nums[i])
                    return new[] { i, j };
            }
        }
        // In case there is no solution, we'll just return null
        return Array.Empty<int>();
    }
}