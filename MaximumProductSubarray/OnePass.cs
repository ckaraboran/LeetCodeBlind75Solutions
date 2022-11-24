/*
Complexity Analysis:
Time complexity: O(n)
Space complexity O(1)
 */

namespace MaximumProductSubarray;

public class OnePass : IMaximumProductSubarrayFinder
{
    public int MaxProduct(int[] nums)
    {
        int max = nums[0], min = nums[0], ans = nums[0];
        int n = nums.Length;

        for (int i = 1; i < n; i++)
        {
            // Swapping min and max
            if (nums[i] < 0)
            {
                (max, min) = (min, max);
            }

            max = Math.Max(nums[i], max * nums[i]);
            min = Math.Min(nums[i], min * nums[i]);
            
            ans = Math.Max(ans, max);
        }

        return ans;
    }
}