/*
 * Complexity Analysis:
 * Time complexity: O(log n)
 * Space complexity O(1)
 */

namespace SearchInRotatedSortedArray;

public class BinarySearch : ISearchInRotatedSortedArray
{
    public int Search(int[] nums, int target)
    {
        int start = 0, end = nums.Length - 1;
        while (start < end)
        {
            var mid = (start + end) / 2;
            if (nums[mid] > nums[end])
            {
                // eg. 3,4,5,6,1,2
                if (target > nums[mid] || target <= nums[end])
                    start = mid + 1;
                else
                    end = mid;
            }
            else
            {
                // eg. 5,6,1,2,3,4
                if (target > nums[mid] && target <= nums[end])
                    start = mid + 1;
                else
                    end = mid;
            }
        }

        if (start == end && target != nums[start]) return -1;
        return start;
    }
}