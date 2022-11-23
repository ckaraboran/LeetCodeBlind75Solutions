/*
Complexity Analysis:
Time complexity: O(n)
Space complexity O(n)
 */

namespace MaximumSubarray;

public class OnePass : IMaximumSubarrayFinder
{
    public int MaxSubArray(int[] nums) {
        // Initialize currMaxSum & take first element of array from which we start to do sum...
        int maxSum = nums[0];
        // Initialize the current sum of our subarray as nums[0]...
        int currSum = nums[0];
        // Traverse all the element through the loop...
        for (int i = 1; i < nums.Length; i++) {
            // Do sum of elements contigous with curr sum...
            // Compare it with array element to get maximum result...
            currSum = Math.Max(currSum + nums[i], nums[i]);
            // Compare current sum and max sum.
            maxSum = Math.Max(maxSum, currSum);
        }
        return maxSum;      // return the contiguous subarray which has the largest sum...
    }
}