/*
 * Complexity Analysis:
 * Time complexity: O(log n)
 * Space complexity O(1)
 */

namespace FindMinimumInRotatedSortedArray;

public class BinarySearch : IMinimumInRotatedSortedArrayFinder
{
    public int FindMin(int[] nums)
    {
        var start = 0;
        var end = nums.Length - 1;

        while (start < end)
        {
            if (nums[start] < nums[end])
                return nums[start];

            var mid = (start + end) / 2;

            if (nums[mid] >= nums[start])
                start = mid + 1;
            else
                end = mid;
        }

        return nums[start];
    }
}